namespace LoggerManager
{
    public interface ILoggManager
    {
        void LogError(string message);
        void LogWarning(string message);
        void LogInfo(string message);
        void LogDebug(string message);
    }
}
