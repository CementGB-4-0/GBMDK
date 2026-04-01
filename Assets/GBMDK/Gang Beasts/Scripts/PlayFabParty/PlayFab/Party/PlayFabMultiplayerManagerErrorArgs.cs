using System;

namespace PlayFab.Party
{
    public class PlayFabMultiplayerManagerErrorArgs : EventArgs
    {
        public PlayFabMultiplayerManagerErrorArgs()
        {
        }

        public PlayFabMultiplayerManagerErrorArgs(int code, string message, PlayFabMultiplayerManagerErrorType type)
        {
        }

        public int Code { get; protected set; }

        public string Message { get; protected set; }

        public PlayFabMultiplayerManagerErrorType Type { get; protected set; }
    }
}