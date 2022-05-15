
namespace CompositeDesignPattern_Example
{
    class BiController
    {
        private readonly ILogger logger;

        public BiController(ILogger logger)
        {
            this.logger = logger;
        }

        public void Interact(string message)
        {
            this.logger.WriteLog(message);
        }
    }
}
