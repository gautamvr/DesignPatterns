using System;

namespace AdapterPattern_Example
{
    /// <summary>
    /// Client side code
    /// </summary>
    public class AdapterPattern_Example
    {
        public static void Main(string[] args)
        {
            // Create adapter and place a request
            IProcessor target = new Adapter();
            target.Request();
            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Target' class (latest interface used by client)
    /// </summary>
    public interface IProcessor
    {
        void Request();
    }

    /// <summary>
    /// The 'Adapter' class (translator for new interface to use incompatible class)
    /// </summary>
    public class Adapter : IProcessor
    {
        private LegacyProcessor _legacyProcessor = new LegacyProcessor();
        public void Request()
        {
            // Possibly do some other work
            // and then call SpecificRequest
            _legacyProcessor.SpecificRequest();
        }
    }

    /// <summary>
    /// The legacy class (incompatible with the new code)
    /// </summary>
    public class LegacyProcessor
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }
}
