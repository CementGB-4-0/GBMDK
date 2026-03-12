using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform.Systems.Progression
{
    public interface IProgressionManager
    {
        void SetAchievement(LocalID localID, string achievementCode, bool unlock);

        bool IsAchievementUnlocked(LocalID localID, string achievementCode);
    }
}