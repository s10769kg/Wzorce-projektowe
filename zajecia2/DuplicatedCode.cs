namespace zajecia2
{
    public class Logger
    {

        private string FormatLogMessage(string logLevel, string message, DateTime timestamp)
        {
            string formattedTimestamp = timestamp.ToString("yyyy-MM-dd HH:mm:ss");
            return $"{logLevel}: [{formattedTimestamp}] {message}";
        }


        public void LogError(string message, DateTime timestamp)
        {
            string formattedMessage = FormatLogMessage("ERROR", message, timestamp);
            Console.WriteLine(formattedMessage);
        }


        public void LogWarning(string message, DateTime timestamp)
        {
            string formattedMessage = FormatLogMessage("WARNING", message, timestamp);
            Console.WriteLine(formattedMessage);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            DateTime timestamp = DateTime.Now;


            logger.LogError("This is an error message", timestamp);
            logger.LogWarning("This is a warning message", timestamp);
        }
    }
}

