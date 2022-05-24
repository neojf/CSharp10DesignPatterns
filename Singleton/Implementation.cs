namespace Singleton
{
    /// <summary>
    /// Singleton logger using Lazy feature.
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

        private Logger()
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

    /// <summary>
    /// Singleton logger using double checked locking.
    /// </summary>
    public class Logger2
    {
        private static Logger2? _instance;
        private static readonly object _lock = new object();

        public static Logger2 Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock(_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Logger2();
                        }
                    }
                }
                return _instance;
            }
        }

        private Logger2()
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
