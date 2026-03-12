namespace CS.CorePlatform
{
    public enum MessageTypes
    {
        UNKNOWN = 0,
        GAMEINVITE = 1,
        BEENKICKED = 2,
        VOICECHAT_DATA = 3,
        VOICECHAT_END = 4,
        USER_MESSAGE = 5,
        LOBBY_HOST_MESSAGE = 6,
        LOBBY_CLIENT_MESSAGE = 7,
        LOBBY_USER_MESSAGE = 8,
        IP_REQUEST = 9,
        IP_RESULT = 10,
        PING = 11,
        PONG = 12,
        DEBUG = 13
    }
}