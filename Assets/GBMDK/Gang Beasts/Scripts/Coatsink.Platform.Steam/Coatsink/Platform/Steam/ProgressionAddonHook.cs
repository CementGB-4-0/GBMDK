using System.Collections.Generic;
using System.Timers;
using Coatsink.Platform.Systems;
using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform.Steam
{
    public class ProgressionAddonHook : IAddon
    {
        private IDictionary<string, string> _achievementCodes;

        private object _locker;

        private bool _needSend;

        private IDictionary<string, string> _statisticCode;

        private Timer _timer;

        public ProgressionAddonHook(IDictionary<string, string> achievementCodes,
            IDictionary<string, string> statisticCode, float updateTimeSec = 5f)
        {
        }

        public string Tag => null;

        ~ProgressionAddonHook()
        {
        }

        protected void OnAchievementChanged(LocalID localID, string achievementCode, bool unlocked)
        {
        }

        protected void OnStatisticChangedFloat(LocalID localID, string statisticCode, float value)
        {
        }

        protected void OnStatisticChangedInt(LocalID localID, string statisticCode, int value)
        {
        }

        protected void OnStatisticChangedMask(LocalID localID, string statisticCode, int value)
        {
        }

        private void TrySendUpdate()
        {
        }

        private void SendUpdate()
        {
        }

        private void CheckSendUpdate(object sender, ElapsedEventArgs e)
        {
        }
    }
}