namespace Singleton
{
    /// <summary>
    /// Singleton.
    /// </summary>
    public class Logger
    {
        private static readonly Lazy<Logger> _lazyLogger
            = new Lazy<Logger>(() => new Logger());

        public static Logger Instance
        {
            get
            {
                return _lazyLogger.Value;
            }
        }

        protected Logger()
        {
        }

        /// <summary>
        /// SingletonOperation
        /// </summary>
        /// <param name="message"></param>
        public void Log(string message)
        {
            Console.WriteLine($"Message to log: {message}");
        }
    }
}
