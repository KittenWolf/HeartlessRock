namespace HeartlessRock.Events
{
    internal interface ILogger
    {
        void LogMessage(string message);
    }

    internal abstract class EventLogger : ILogger
    {
        public void LogEvent(GameEventArgs args) 
        {
            LogMessage(args.ToString());
        }

        public abstract void LogMessage(string message);
    }

    internal class EventConsoleLogger : EventLogger
    {
        public override void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

    internal class EventFileLogger : EventLogger
    {
        public override void LogMessage(string message)
        {
            // file stram
        }
    }
}
