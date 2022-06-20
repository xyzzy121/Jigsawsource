using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NBitcoin;
using QBitNinja.Client;

namespace AddressWizard
{
    public partial class FormMain : Form
    {
        private decimal _btcStored;
        private decimal BtcStored
        {
            get { return _btcStored; }
            set
            {
                _btcStored = value;
                UpdateLabelBtcStoredText(_btcStored + @" BTC"); //setting label to value
            }
        }
        delegate void UpdateLabelBtcStoredTextDelegate(string newText);
        private void UpdateLabelBtcStoredText(string newText)
        {
            if (labelBtcStored.InvokeRequired)
            {
                // this is worker thread
                UpdateLabelBtcStoredTextDelegate del = UpdateLabelBtcStoredText;
                labelBtcStored.Invoke(del, newText);
            }
            else
            {
                // this is UI thread
                labelBtcStored.Text = newText;
            }
        }

        private double _chkdAddrPc;
        private double ChkdAddrPc
        {
            set
            {
                _chkdAddrPc = value;
                UpdateLabelChkdAddrPcText(_chkdAddrPc + @"%"); //setting label to value
            }
        }

        delegate void UpdateLabelChkdAddrPcTextDelegate(string newText);
        private void UpdateLabelChkdAddrPcText(string newText)
        {
            if (labelChkdAddrPc.InvokeRequired)
            {
                // this is worker thread
                UpdateLabelChkdAddrPcTextDelegate del = UpdateLabelChkdAddrPcText;
                labelChkdAddrPc.Invoke(del, newText);
            }
            else
            {
                // this is UI thread
                labelChkdAddrPc.Text = newText;
            }
        }

        const string WorkFolderPath = @"work";
        const string FilePathAddresses = WorkFolderPath + @"\vanityAddresses.txt";
        const string FilePathNotEmptyAddresses = WorkFolderPath + @"\notEmptyAddresses.txt";
        const string FilePathSecretKeys = WorkFolderPath + @"\addressSecretPairs.txt";
        const string FilePathLastUpdate = @"lastUpdate.txt";

        // 100       - small, doesn't matter
        // 1 000     - small, doesn't matter
        // 10 000    - 0.36MB
        // 100 000   - 3.6MB
        // 1 000 000 - 36MB, too big 
        private int _addressCnt = 100;
        private readonly List<int> _fileSizesMb = new List<int> { 100, 1000, 10000, 100000 };

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonNotEmptyAddresses.Enabled = false;
            labelBtcStored.Enabled = false;
            pictureBoxAddressGenerating.Visible = false;
            pictureBoxBackgroundAddrGen.Visible = true;
            pictureBoxRefreshing.Visible = false;
            pictureBoxBackgroundWallet.Visible = true;

            labelStatusGenAddr.Text = "";

            CheckUpdate();

            _fileSizesMb.ForEach(x => comboBoxFileSize.Items.Add(x));
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            pictureBoxAddressGenerating.Visible = true;
            pictureBoxBackgroundAddrGen.Visible = false;
            buttonStart.Enabled = false;
            comboBoxFileSize.Enabled = false;
            labelStatusGenAddr.Text = @"Addresses are being generated...";

            backgroundWorkerStart.RunWorkerAsync();
        }

        private void buttonOpenAddressFolder_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(WorkFolderPath)) Directory.CreateDirectory(WorkFolderPath);

            Process.Start(WorkFolderPath);
        }

        private void backgroundWorkerStart_DoWork(object sender, DoWorkEventArgs e)
        {
            var keys = new HashSet<Key>();
            for (var i = 0; i < _addressCnt; i++)
            {
                var key = new Key();

                keys.Add(key);
            }

            if (!Directory.Exists(WorkFolderPath)) Directory.CreateDirectory(WorkFolderPath);
            if (File.Exists(FilePathAddresses)) File.Delete(FilePathAddresses);
            if (File.Exists(FilePathSecretKeys)) File.Delete(FilePathSecretKeys);
            using (var sw = File.CreateText(FilePathAddresses))
            using (var sw2 = File.CreateText(FilePathSecretKeys))
            {
                foreach (var key in keys)
                {
                    var addr = key.PubKey.GetAddress(Network.Main).ToString();
                    sw.WriteLine(addr);
                    sw2.WriteLine(addr + ":" + key.GetBitcoinSecret(Network.Main));
                }
                sw.Flush();
                sw2.Flush();
            }

            var sortedAddresses = new SortedSet<string>();
            var sortedSecretKeys = new SortedSet<string>();
            foreach (var line in File.ReadAllLines(FilePathAddresses))
            {
                sortedAddresses.Add(line);
            }
            foreach (var line in File.ReadAllLines(FilePathSecretKeys))
            {
                sortedSecretKeys.Add(line);
            }
            if (File.Exists(FilePathAddresses)) File.Delete(FilePathAddresses);
            if (File.Exists(FilePathSecretKeys)) File.Delete(FilePathSecretKeys);
            using (var sw = File.CreateText(FilePathAddresses))
            using (var sw2 = File.CreateText(FilePathSecretKeys))
            {
                foreach (var a in sortedAddresses)
                    sw.WriteLine(a);
                foreach (var s in sortedSecretKeys)
                    sw2.WriteLine(s);

                sw.Flush();
                sw2.Flush();
            }

        }

        private void backgroundWorkerStart_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            buttonStart.Enabled = true;
            comboBoxFileSize.Enabled = true;
            pictureBoxAddressGenerating.Visible = false;
            pictureBoxBackgroundAddrGen.Visible = true;
            labelStatusGenAddr.Text = @"Address generation is finished.";
        }

        private void comboBoxFileSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            _addressCnt = (int)comboBoxFileSize.SelectedItem;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            labelBtcStored.Enabled = false;
            buttonNotEmptyAddresses.Enabled = false;
            buttonRefresh.Enabled = false;
            pictureBoxRefreshing.Visible = true;
            pictureBoxBackgroundWallet.Visible = false;

            backgroundWorkerRefresh.RunWorkerAsync();
        }

        private void backgroundWorkerRefresh_DoWork(object sender, DoWorkEventArgs e)
        {
            SetBtcStored();
        }

        private void backgroundWorkerRefresh_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            labelBtcStored.Enabled = true;

            if (BtcStored > 0)
            {
                buttonNotEmptyAddresses.Enabled = true;
            }
            buttonRefresh.Enabled = true;
            pictureBoxRefreshing.Visible = false;
            pictureBoxBackgroundWallet.Visible = true;

            labelBtcStored.Text = BtcStored + @" BTC";
        }

        private void SetBtcStored()
        {
            BtcStored = 0;
            ChkdAddrPc = 0;

            if (!Directory.Exists(WorkFolderPath)) Directory.CreateDirectory(WorkFolderPath);
            if (!File.Exists(FilePathAddresses) || !File.Exists(FilePathSecretKeys))
            {
                MessageBox.Show(@"You haven't generated addresses yet.", @"Error");
                return;
            }
            if (File.Exists(FilePathNotEmptyAddresses)) File.Delete(FilePathNotEmptyAddresses);
            using (var sw = File.CreateText(FilePathNotEmptyAddresses))
            {
                var filePathAddresses = File.ReadAllLines(FilePathAddresses);
                
                var addrCount = filePathAddresses.Count();
                var addrIdx = 0;

                const int chunkSize = 20;
                var currChunk = 1;

                while (addrIdx < filePathAddresses.Length)
                {
                    try
                    {
                        var currAddresses = new HashSet<string>();
                        for (var i = addrIdx; i < currChunk*chunkSize; i++)
                        {
                            if (i >= filePathAddresses.Length) continue;

                            currAddresses.Add(filePathAddresses[i]);
                        }

                        var qbitClient = new QBitNinjaClient(Network.Main);
                        var currAddrBalBtcDict = new Dictionary<string, decimal>();
                        foreach (var addr in currAddresses)
                        {
                            var sum = qbitClient.GetBalanceSummary(BitcoinAddress.Create(addr)).Result;
                            var bal = sum.Confirmed.Amount + sum.UnConfirmed.Amount;
                            currAddrBalBtcDict.Add(addr, bal.ToDecimal(MoneyUnit.BTC));
                        }

                        foreach (var elem in currAddrBalBtcDict.Where(elem => elem.Value > 0))
                        {
                            BtcStored += elem.Value;
                            var a = elem.Key;
                            foreach (
                                var pubsec in
                                    File.ReadAllLines(FilePathSecretKeys).Where(pubsec => pubsec.StartsWith(a)))
                            {
                                sw.WriteLine(pubsec);
                            }
                            sw.Flush();
                        }
                    }
                    catch
                    {
                        continue;
                    }

                    addrIdx += chunkSize;
                    currChunk++;

                    var tmpChkdAddrPc = 100*((addrIdx)/(double) addrCount);
                    ChkdAddrPc = tmpChkdAddrPc < 100 ? tmpChkdAddrPc : 100;
                }
            }
        }

        private void buttonNotEmptyAddresses_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(WorkFolderPath)) Directory.CreateDirectory(WorkFolderPath);

            Process.Start(WorkFolderPath);
        }

        private void CheckUpdate()
        {
            SetCheckingForUpdate();
            backgroundWorkerCheckForUpdates.RunWorkerAsync();
        }
        private void SetCheckingForUpdate()
        {
            buttonUpdate.Enabled = false;
            buttonUpdate.BackColor = Color.DarkOrange;
            buttonUpdate.Text = @"Checking for updates...";
        }
        private void SetUpToDate()
        {
            buttonUpdate.Enabled = false;
            buttonUpdate.BackColor = Color.Lime;
            buttonUpdate.Text = @"You are up to date!";

            File.WriteAllText(FilePathLastUpdate, _newUpdateDate);
            _lastUpdateDate = _newUpdateDate;
        }

        private void SetOutOfDate()
        {
            buttonUpdate.Enabled = true;
            buttonUpdate.BackColor = Color.Tomato;
            buttonUpdate.Text = @"You are out of date... Please click on me";
        }

        private void SetDontKnowIfUpToDate()
        {
            buttonUpdate.Enabled = false;
            buttonUpdate.BackColor = Color.Turquoise;
            buttonUpdate.Text = @"Can't check for updates. Is your Windows torified?";
        }

        private static string _newUpdateDate;
        private static string _lastUpdateDate;

        private static bool IsUpToDate(string newDate)
        {
            _newUpdateDate = newDate.Trim();
            if (!File.Exists(FilePathLastUpdate))
            {
                File.WriteAllText(FilePathLastUpdate, _newUpdateDate);
                _lastUpdateDate = _newUpdateDate;
                return true;
            }

            _lastUpdateDate = File.ReadAllText(FilePathLastUpdate).Trim();
            if (_lastUpdateDate == _newUpdateDate)
            {
                return true;
            }
            return false;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(this, @"Your software might be up to date, but you might not. If you see this message it means something has been added to the developer logs at funWithCodes.info. Will you check it out? If yes I will not bother you with this irritating red button again.", @"Please update yourself", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SetUpToDate();
            }
            else if (result == DialogResult.No)
            {
                SetOutOfDate();
            }
            else
            {
                SetDontKnowIfUpToDate();
            }
        }

        enum UpdateStatus { UpToDate, OutOfDate, Undefined };

        private static UpdateStatus _updateStatus = UpdateStatus.Undefined;

        private void backgroundWorkerCheckForUpdates_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var funWithCodesPlayground = new FunWithCodesPlayGorund();

                _lastUpdateDate = funWithCodesPlayground.GetLastUpdateDateSync();
                _updateStatus = IsUpToDate(_lastUpdateDate) ? UpdateStatus.UpToDate : UpdateStatus.OutOfDate;
            }
            catch
            {
                _updateStatus = UpdateStatus.Undefined;
            }
        }

        private void backgroundWorkerCheckForUpdates_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_updateStatus == UpdateStatus.Undefined)
            {
                SetDontKnowIfUpToDate();
            }
            if (_updateStatus == UpdateStatus.OutOfDate)
            {
                SetOutOfDate();
            }
            if (_updateStatus == UpdateStatus.UpToDate)
            {
                SetUpToDate();
            }
        }
    }
}
