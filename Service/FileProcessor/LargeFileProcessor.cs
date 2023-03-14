using System.IO;

namespace TestingMultipleImplementatinOfDi
{
    public class LargeFileProcessor : IFileProcessorStrategy
    {
        public string ProcessFile()
        {
            return "Process large file";
        }
    }
}
