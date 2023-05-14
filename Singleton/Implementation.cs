namespace Singleton
{
    internal class Logger
    {
        //private static Logger? _instance;

        private static readonly Lazy<Logger> _instanceLazy = new Lazy<Logger>(() => new Logger());

        public static Logger Instance
        {
            get
            {
                return _instanceLazy.Value;
                //return _instance ?? (_instance = new Logger());
            }
        }

        protected Logger()
        {

        }

        public void Log(string message)
        {
            Console.WriteLine($"Message to log {message}");
        }
    }

}
