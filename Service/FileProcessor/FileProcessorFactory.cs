namespace TestingMultipleImplementatinOfDi
{
    public class FileProcessorFactory
    {
        private readonly IFileProcessorStrategy largeFileProcessor = new LargeFileProcessor();
        private readonly IFileProcessorStrategy smallFileProcessor = new SmallFileProcessor();

        public IFileProcessorStrategy getFileProcessorStrategy(bool isLarge)
        {
            switch (isLarge)
            {
                case true: 
                    return largeFileProcessor;
                case false:
                    return smallFileProcessor;
                default:
                    return null;
            }
        }
    }
}
