namespace TestingMultipleImplementatinOfDi
{
    public class Context
    {
        private IFileProcessor _strategy;

        public Context()
        { }

        public Context(IFileProcessor strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(IFileProcessor strategy)
        {
            this._strategy = strategy;
        }

        public string DoSomeBusinessLogic()
        {
            return this._strategy.ProcessFile();
        }
    }
}
