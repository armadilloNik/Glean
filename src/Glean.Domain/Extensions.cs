using System.IO;
using System.Linq;

namespace Glean.Domain
{
    public static class Extensions
    {
        public static string ToPowerShell(this FileSearch search)
        {
            return
                $"${search.Name}=[System.IO.Directory]::EnumerateFiles({search.SearchPath.Qt()},{search.SearchPattern.Qt()},{search.SearchOption.Qt()})";
        }

        public static string Qt(this string toQuote)
        {
            return "\"" + toQuote + "\"";
        }

        public static string Qt(this SearchOption option)
        {
            return option.ToString().Qt();
        }
        
    }
}