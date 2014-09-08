namespace ToysStore.RandomDataGenerator.Contracts
{
    internal interface ILogger
    {
        void Log(string message);

        void StartOfNotification(string message);

        void NotifyProgress();

        void EndOfNotification();
    }
}
