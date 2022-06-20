using System.Text.RegularExpressions;

namespace AddressWizard
{
    public static class Tools
    {
        public static bool IsBtcAddress(string addr)
        {
            // BTC address length from 26 to 34
            if (addr.Length < 26 || addr.Length > 34) return false;
            var r = new Regex("^(1|3)[123456789ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz].*$");
            if (!r.IsMatch(addr)) return false;
            return true;
        }
    }
}
