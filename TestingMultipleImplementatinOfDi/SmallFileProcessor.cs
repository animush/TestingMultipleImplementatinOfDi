using System.IO;

namespace TestingMultipleImplementatinOfDi
{
    public class SmallFileProcessor : IFileProcessor
    {
        public string ProcessFile()
        {
            return "Process small file";
        }
    }
}
