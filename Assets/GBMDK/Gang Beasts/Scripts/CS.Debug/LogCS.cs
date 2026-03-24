using UnityEngine;

public class LogCS
{
    public enum LogType
    {
        LogInfo = 2,
        LogWarning = 4,
        LogError = 8
    }

    public const int MaxNumOfLogFiles = 6;

    public const string logFolder = "LogCS";

    public const string CustomFileName = "Gang Beasts Log";

    private const LogType activeLogType = LogType.LogError;

    public static bool loggingEnabled;

    public static bool VerboseStackClassLogs;

    private static string _CurrentFilePath;

    private static bool _logToCustomFile;

    private static bool LogToUnityConsole;

    private static bool initialised;

    public static bool LogToCustomFile
    {
        get { return false; }
        set { }
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
    private static void ResetStatics()
    {
    }

    public static void Setup(string logFile = null)
    {
    }

    private static bool CreateFile(string path)
    {
        return false;
    }

    private static string GetStackTrace(int stackDepth)
    {
        return null;
    }

    private static string GetPreviousMethodCaller()
    {
        return null;
    }

    public static void LogFormatI(string format, params object[] args)
    {
    }

    public static void LogFormatW(string format, params object[] args)
    {
    }

    public static void LogFormatE(string format, params object[] args)
    {
    }

    public static void Log(object logMessage, LogType type = LogType.LogInfo, int stackTraceDepth = 2,
        bool alwaysLog = false)
    {
    }
}