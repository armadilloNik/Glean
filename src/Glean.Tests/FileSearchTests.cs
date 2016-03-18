using System.IO;
using Glean.Domain;
using Xunit;

namespace Glean.Tests
{
    public class FileSearchTests
    {
        [Fact]
        public void should_create_file_search_statement_in_powershell()
        {
            var fileSearch = new FileSearch()
            {
                Name = "configFiles",
                SearchOption = SearchOption.AllDirectories,
                SearchPath = "c:\\temp",
                SearchPattern = "*.config"
            };

            var actual = fileSearch.ToPowerShell();

           Assert.Equal("$configFiles=[System.IO.Directory]::EnumerateFiles(\"c:\\temp\",\"*.config\",\"AllDirectories\")", actual);
        }
    }
}
