namespace DesignPatterns.Behavioral.Observer.Ex2
{
    public class LoggingListener : IEventListener
    {
        private readonly File _log;
        private readonly string _message;

        public LoggingListener(string logFileName, string message)
        {
            _log = new File(logFileName);
            _message = message;
        }

        public void Update(string fileName)
        {
            // _log.Write("Log file name: " + fileName, "Log content: " + _message);
            Console.WriteLine("Log file name: " + fileName, "Log content: " + _message);
        }
    }
}
