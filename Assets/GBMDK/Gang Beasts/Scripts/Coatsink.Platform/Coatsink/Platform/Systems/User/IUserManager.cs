namespace Coatsink.Platform.Systems.User
{
    public interface IUserManager
    {
        int MaxUsers { get; set; }

        LocalID PrimaryUser { get; }

        LocalID LocalID(int controller);

        int GetControllerSlot(LocalID localID);

        string GetUserName(LocalID localID);

        OnlineID GetUserOnlineID(LocalID localID);

        UserInfo GetUserInfo(LocalID localID);

        void UserJoin(int controller, TaskResult<LocalID, int> taskResult);

        int UserLeave(int controller);

        int SetPrimaryUser(LocalID localID);

        void OnlineAllowed(LocalID localID, bool showMessage, bool realtime, TaskResult<LocalID, bool> taskResult);
    }
}