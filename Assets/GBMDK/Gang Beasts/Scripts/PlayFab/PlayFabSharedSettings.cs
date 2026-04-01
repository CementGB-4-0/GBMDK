using PlayFab;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayFabSharedSettings", menuName = "PlayFab/CreateSharedSettings", order = 1)]
public class PlayFabSharedSettings : ScriptableObject
{
    public string TitleId;

    public string ProductionEnvironmentUrl;

    public WebRequestType RequestType;

    public bool DisableDeviceInfo;

    public bool DisableFocusTimeCollection;

    public int RequestTimeout;

    public bool RequestKeepAlive;

    public PlayFabLogLevel LogLevel;

    public string LoggerHost;

    public int LoggerPort;

    public bool EnableRealTimeLogging;

    public int LogCapLimit;

    internal string VerticalName;
}