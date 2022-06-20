using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using NBitcoin;
using Newtonsoft.Json.Linq;

namespace AddressWizard
{
    internal class FunWithCodesPlayGorund
    {
        internal string GetLastUpdateDateSync()
        {
            var bitcoinStealerPage = GetBitcoinStealerPageAsync().Result;
            var bitcoinBlackmailerPage = GetBitcoinBlackmailerPageAsync().Result;

            var bitcoinStealerDevelopmentLogIndex = bitcoinStealerPage.IndexOf("<h2>DEVELOPMENT LOG</h2>", StringComparison.InvariantCulture);
            var bitcoinBlackmailerDevelopmentLogIndex = bitcoinBlackmailerPage.IndexOf("<h2>DEVELOPMENT LOG</h2>", StringComparison.InvariantCulture);

            var bitcoinStealerLastUpdateDate = bitcoinStealerPage.Substring(bitcoinStealerDevelopmentLogIndex + 88, 10).Trim();
            var bitcoinBlackmailerLastUpdateDate = bitcoinBlackmailerPage.Substring(bitcoinBlackmailerDevelopmentLogIndex + 88, 10).Trim();

            try
            {
                DateTime d1, d2;
            
                DateTime.TryParse(bitcoinStealerLastUpdateDate, out d1);
                DateTime.TryParse(bitcoinBlackmailerLastUpdateDate, out d2);

                return d1 > d2
                ? bitcoinStealerLastUpdateDate
                : bitcoinBlackmailerLastUpdateDate;
            }
            catch { 
                // strings didn't parse, but hey,
                // at least you didn't throw an exception!
                return bitcoinBlackmailerLastUpdateDate;
            }
        }

        internal async Task<string> GetBitcoinStealerPageAsync()
        {
            while (true)
            {
                using (var client = new HttpClient())
                {
                    const string request = "http://funwito6ykzrupsj.onion/bitcoin-stealer.html";
                    var response = await client.GetAsync(request).ConfigureAwait(false);

                    if (response.StatusCode == HttpStatusCode.NotFound)
                        return null;
                    var bitcoinStealerPage = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    return bitcoinStealerPage;
                }
            }
        }
        internal async Task<string> GetBitcoinBlackmailerPageAsync()
        {
            while (true)
            {
                using (var client = new HttpClient())
                {
                    const string request = "http://funwito6ykzrupsj.onion/bitcoin-blackmailer.html";
                    var response = await client.GetAsync(request).ConfigureAwait(false);

                    if (response.StatusCode == HttpStatusCode.NotFound)
                        return null;
                    var bitcoinStealerPage = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    return bitcoinStealerPage;
                }
            }
        }
    }
}
