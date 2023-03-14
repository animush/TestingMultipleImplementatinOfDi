using System.IO;

namespace TestingMultipleImplementatinOfDi
{
    public class SmallFileProcessor : IFileProcessorStrategy
    {
        public string ProcessFile()
        {
            return "Process small file";
        }
    }
}
