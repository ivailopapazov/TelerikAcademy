namespace ToysStore.RandomDataGenerator.Tools
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ToysStore.RandomDataGenerator.Contracts;

    internal class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public void StartOfNotification(string message)
        {
            Console.WriteLine(message);
        }

        public void NotifyProgress()
        {
            Console.Write("#");
        }

        public void EndOfNotification()
        {
            Console.WriteLine("{0}DONE!", Environment.NewLine);
        }
    }
}
