namespace StrategyPatternExample
{
    public class ApplicationBootstrapper
    {
        public void Bootstrap()
        {
            StrategyContextCreator quickContext = new StrategyContextCreator(new FasterStrategy());
            quickContext.PerformOperation();

            StrategyContextCreator memoryOptimizedContext = new StrategyContextCreator(new MemoryOptimizedStrategy());
            memoryOptimizedContext.PerformOperation();

            StrategyContextCreator bruteForceContext = new StrategyContextCreator(new BruteForceStrategy());
            bruteForceContext.PerformOperation();;


        }
    }
}