using Coatsink.Platform.Systems;

namespace Coatsink.Platform.Steam
{
    public class Core : IPlatformCore
    {
        private static bool _steamActive;

        private ulong _gameID;

        public Core(ulong gameID = 480uL)
        {
        }

        public ulong GameID => 0uL;

        public PlatformID PlatformID => default(PlatformID);

        public void Initialize(TaskResult<bool> taskResult)
        {
        }

        public void Terminate()
        {
        }

        public void UpdateCore()
        {
        }

        public static bool SteamActive()
        {
            return false;
        }
    }
}