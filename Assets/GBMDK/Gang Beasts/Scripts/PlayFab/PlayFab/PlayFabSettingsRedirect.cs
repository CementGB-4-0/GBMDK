using System;

namespace PlayFab
{
    internal class PlayFabSettingsRedirect : PlayFabApiSettings
    {
        private readonly Func<PlayFabSharedSettings> GetSO;

        public PlayFabSettingsRedirect(Func<PlayFabSharedSettings> getSO)
        {
        }

        public override string ProductionEnvironmentUrl
        {
            get { return null; }
            set { }
        }

        internal override string VerticalName
        {
            get { return null; }
            set { }
        }

        public override string TitleId
        {
            get { return null; }
            set { }
        }

        public override bool DisableDeviceInfo
        {
            get { return false; }
            set { }
        }

        public override bool DisableFocusTimeCollection
        {
            get { return false; }
            set { }
        }
    }
}