using Service.FileProcessor;

namespace TestingMultipleImplementatinOfDi
{
    public class FileProcessor : IFileProcessor
    {
        private readonly FileProcessorFactory fileProcessorFactory = new FileProcessorFactory();

        public string ProcessFile(bool IsLarge)
        {
            IFileProcessorStrategy fileProcessorStrategy = fileProcessorFactory.getFileProcessorStrategy(IsLarge);
            return fileProcessorStrategy.ProcessFile();
        }
    }
}
