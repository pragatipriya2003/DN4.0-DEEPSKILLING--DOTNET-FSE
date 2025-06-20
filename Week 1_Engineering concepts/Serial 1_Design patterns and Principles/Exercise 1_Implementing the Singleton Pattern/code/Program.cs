using System;

namespace SingletonPatternExample
{
    public class Logger
    {
        private static Logger instance;
        private static readonly object lockObj = new object();

        private Logger()
        {
            Console.WriteLine("Logger initialized");
        }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                lock (lockObj)
                {
                    if (instance == null)
                        instance = new Logger();
                }
            }
            return instance;
        }

        public void Log(string message)
        {
            Console.WriteLine("LOG: " + message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            logger1.Log("First message");

            Logger logger2 = Logger.GetInstance();
            logger2.Log("Second message");

            Console.WriteLine(logger1 == logger2 ? "Singleton verified" : "Singleton failed");
        }
    }
}
