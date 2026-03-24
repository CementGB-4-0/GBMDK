using System;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
    [Serializable]
    public class LogStatement : PlayFabBaseModel
    {
        public string Level;

        public string Message;
        public object Data;
    }
}