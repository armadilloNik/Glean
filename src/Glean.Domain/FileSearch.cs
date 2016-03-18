using System.IO;

namespace Glean.Domain
{
    public class FileSearch
    {
        public string Name { get; set; }
        public string SearchPath { get; set; }
        public string SearchPattern { get; set; }
        public SearchOption SearchOption { get; set; }
    }
}

