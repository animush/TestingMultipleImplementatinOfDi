using System.IO;

namespace TestingMultipleImplementatinOfDi
{
    public class LargeFileProcessor : IFileProcessor
    {
        public string ProcessFile()
        {
            return "Process large file";
        }
    }
}
