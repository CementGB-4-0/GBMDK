using System.Collections.Generic;

namespace PlayFab
{
    public class PlayFabApiSettings
    {
        public readonly Dictionary<string, string> _requestGetParams;
        private string _ProductionEnvironmentUrl;

        public virtual Dictionary<string, string> RequestGetParams => null;

        public virtual string ProductionEnvironmentUrl
        {
            get { return null; }
            set { }
        }

        public virtual string TitleId { get; set; }

        internal virtual string VerticalName { get; set; }

        public virtual bool DisableDeviceInfo { get; set; }

        public virtual bool DisableFocusTimeCollection { get; set; }

        public virtual string GetFullUrl(string apiCall, Dictionary<string, string> getParams)
        {
            return null;
        }
    }
}