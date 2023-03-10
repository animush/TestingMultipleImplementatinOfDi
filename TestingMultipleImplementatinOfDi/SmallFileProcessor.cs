using System.IO;

namespace TestingMultipleImplementatinOfDi
{
    public class SmallFileProcessor : IFileProcessor
    {
        public void ProcessFile()
        {
            System.Console.WriteLine("Process small file");
        }
    }
}
