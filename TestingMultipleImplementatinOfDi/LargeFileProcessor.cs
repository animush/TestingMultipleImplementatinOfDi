using System.IO;

namespace TestingMultipleImplementatinOfDi
{
    public class LargeFileProcessor : IFileProcessor
    {
        public void ProcessFile()
        {
            System.Console.WriteLine("Process large file"); 
        }
    }
}
