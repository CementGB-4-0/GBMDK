using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Coatsink.Platform;
using Coatsink.Platform.Systems.Online;
using Coatsink.Platform.Systems.User;
using CS.CorePlatform;
using Unity.Services.Lobbies;
using Unity.Services.Lobbies.Models;
using PlatformID = Coatsink.Platform.Systems.PlatformID;

namespace GangBeastsUnityLobby.Platform
{
    public class Lobby : ILobby
    {
        protected const string CROSSPLAY_ENABLED = "enabled";

        protected const string CROSSPLAY_DISABLED = "disabled";

        protected const string key_DisplayName = "DisplayName";

        protected const string key_PlatformIndex = "PlatformType";

        protected const string key_PlatformSpecificPlayerId = "PlatformId";

        protected const string key_LastUpdateTime = "LastUpdated";

        protected const string key_RelayJoinCode = "RelayJoinCode";

        protected const string key_Crossplay = "Crossplay";

        private const double _time_s_WithoutPingBeforeKick = 60.0;

        private const int _time_ms_BetweenPings = 5000;

        protected const int _time_ms_AllowedForInitialCreate = 13000;

        protected const int _time_ms_AllowedForInitialJoin = 13000;

        protected const int _time_ms_AllowedForBindToLobby = 11000;

        protected const int _time_ms_AllowedForRelayCreate = 9000;

        protected const int _time_ms_AllowedForRelayJoin = 9000;

        protected LobbyStringID _currentLobby;

        protected List<LobbyMember> _currentMembers;

        protected CancellationTokenSource _currentTimeoutCancelSource;

        protected CancellationToken _currentTimeoutCancelToken;

        private bool _debugPreventPlayerTimeoutKick;

        protected TaskResult<ILobby> _enteringLobbyTask;

        protected bool _hasConnectedToRelay;

        protected UserInfo _hostID;

        protected bool _isHost;

        protected bool _joinable;

        protected TaskResult<ILobby> _leavingLobbyTask;

        protected object _locker;

        protected int _maxPlayers;

        protected RelayPostBox _relayPostBox;

        private int _subsequentFailedPings;

        public IInviteInterface InviteInterface;

        private PlatformID localPlatfromID;

        protected Unity.Services.Lobbies.Models.Lobby m_CurrentLobby;

        private Task m_HeartBeatTask;

        protected LobbyEventCallbacks m_LobbyEventCallbacks;

        public Lobby(PlatformID InPlatformID)
        {
        }

        public ILobbyID LobbyID => null;

        public UserInfo Host => default(UserInfo);

        public bool IsInLobby => false;

        public bool IsLobbyHost => false;

        public bool IsJoiningLobby => false;

        public int TotalInLobby => 0;

        public virtual bool Joinable
        {
            get { return false; }
            set { }
        }

        public event LobbyUserEvent OnUserLeft
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event LobbyUserEvent OnUserJoin
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event LobbyUserEvent OnHostChanged
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event LobbyIdEvent OnLobbyClosed
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public TaskResult<ILobby> CreateLobby(LocalID join, uint maxSlots, TaskResult<ILobby> task = null)
        {
            return null;
        }

        public TaskResult<ILobby> JoinLobby(LocalID join, ILobbyID id, string joinCode = null,
            TaskResult<ILobby> task = null)
        {
            return null;
        }

        public TaskResult<ILobby> LeaveLobby(TaskResult<ILobby> task = null)
        {
            return null;
        }

        public string GetJoinCode()
        {
            return null;
        }

        public uint GetLobbyUsers(ref List<UserInfo> users)
        {
            return 0u;
        }

        public string GetUserName(UserInfo userInfo)
        {
            return null;
        }

        public bool KickUser(UserInfo kickTarget)
        {
            return false;
        }

        public TaskResult<ILobby> ShowInviteUI(LocalID localID, int maxInvites, TaskResult<ILobby> task = null)
        {
            return null;
        }

        public virtual bool SendLobbyMessage(UserInfo userInfo, byte[] message)
        {
            return false;
        }

        public virtual void LobbyUpdate()
        {
        }

        public event LobbyIdEvent OnLobbyEntered
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        protected event Action _onLobbyTaskEnded
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public void GetUserInfoFromUnityID(string unityId, ref UserInfo userInfo)
        {
        }

        public string GetUnityIdFromUserInfo(UserInfo user)
        {
            return null;
        }

        public bool IsUserInLobby(UserInfo user)
        {
            return false;
        }

        ~Lobby()
        {
        }

        [AsyncStateMachine(typeof(_003CGetUnityAuthIdAsync_003Ed__82))]
        private Task<string> GetUnityAuthIdAsync()
        {
            return null;
        }

        private Dictionary<string, PlayerDataObject> CreateInitialPlayerData(LocalID user)
        {
            return null;
        }

        protected void GetDataForPlayer(Player inPlayer, out string uasId, out string displayName,
            out PlatformKeys platformKey, out OnlineID platformSpecificPlayerId, out bool playerIsHost,
            out DateTime lastUpdateTime)
        {
            uasId = null;
            displayName = null;
            platformKey = default(PlatformKeys);
            platformSpecificPlayerId = default(OnlineID);
            playerIsHost = default(bool);
            lastUpdateTime = default(DateTime);
        }

        [AsyncStateMachine(typeof(_003CCreateLobbyAsync_003Ed__85))]
        protected virtual Task CreateLobbyAsync(Dictionary<string, PlayerDataObject> playerData, uint maxSlots,
            TaskResult<ILobby> task = null)
        {
            return null;
        }

        protected virtual void OnLobbyJoined()
        {
        }

        [AsyncStateMachine(typeof(_003CJoinLobbyAsync_003Ed__88))]
        protected virtual Task JoinLobbyAsync(Dictionary<string, PlayerDataObject> playerData, string lobbyId,
            string lobbyCode = null)
        {
            return null;
        }

        [AsyncStateMachine(typeof(_003CLeaveLobbyAsync_003Ed__90))]
        protected virtual Task LeaveLobbyAsync()
        {
            return null;
        }

        protected virtual void LobbyCreationCompleted(uint errorCode = uint.MaxValue)
        {
        }

        protected virtual void LobbyJoiningCompleted(uint errorCode = 0u)
        {
        }

        protected bool CheckIsLobbyTaskCancelled()
        {
            return false;
        }

        protected void StartLobbyTaskTimeoutCheck(int time_ms_AllowedForTask, bool isCreatingLobby)
        {
        }

        [AsyncStateMachine(typeof(_003CCheckForLobbyTaskTimeoutAsync_003Ed__96))]
        private void CheckForLobbyTaskTimeoutAsync(int time_ms_AllowedForTask, bool isCreatingLobby)
        {
        }

        [AsyncStateMachine(typeof(_003CKickUserAsync_003Ed__100))]
        protected Task KickUserAsync(string kickTargetId)
        {
            return null;
        }

        [AsyncStateMachine(typeof(_003CGetLobbyData_003Ed__104))]
        private Task GetLobbyData(bool refreshFromRemote = false)
        {
            return null;
        }

        [AsyncStateMachine(typeof(_003CBindToRemoteLobbyEvents_003Ed__105))]
        protected virtual Task<bool> BindToRemoteLobbyEvents(string lobbyID)
        {
            return null;
        }

        [AsyncStateMachine(typeof(_003COnLobbyDeleted_003Ed__106))]
        protected virtual void OnLobbyDeleted()
        {
        }

        [AsyncStateMachine(typeof(_003COnPlayerJoined_003Ed__107))]
        protected virtual void OnPlayerJoined(List<LobbyPlayerJoined> players)
        {
        }

        protected virtual void OnPlayerLeft(List<int> leavingPlayerIndexes)
        {
        }

        [AsyncStateMachine(typeof(_003COnLobbyDataChanged_003Ed__109))]
        protected virtual void OnLobbyDataChanged(ILobbyChanges changes)
        {
        }

        [AsyncStateMachine(typeof(_003CHostHeartbeatPingAsync_003Ed__113))]
        private Task HostHeartbeatPingAsync()
        {
            return null;
        }

        [AsyncStateMachine(typeof(_003CPlayerUpdatePingAsync_003Ed__114))]
        private Task PlayerUpdatePingAsync()
        {
            return null;
        }

        protected void StartHeartBeat()
        {
        }

        [AsyncStateMachine(typeof(_003CHeartBeatLoop_003Ed__116))]
        private Task HeartBeatLoop()
        {
            return null;
        }

        private uint CheckLobbyCompatibilityWithCrossplaySettings()
        {
            return 0u;
        }

        private bool OnWantToQuit()
        {
            return false;
        }

        [AsyncStateMachine(typeof(_003CLeaveLobbyBeforeQuitAsync_003Ed__119))]
        private void LeaveLobbyBeforeQuitAsync(TaskResult<ILobby> leaveTask)
        {
        }

        [AsyncStateMachine(typeof(_003CHostBindPostBoxToRelay_003Ed__120))]
        protected Task HostBindPostBoxToRelay()
        {
            return null;
        }

        [AsyncStateMachine(typeof(_003CPlayerBindPostBoxToRelay_003Ed__121))]
        protected Task<bool> PlayerBindPostBoxToRelay()
        {
            return null;
        }

        private void OnRelayAllocationBound(Guid allocationId, string joinCode)
        {
        }

        private void ClearLobby()
        {
        }

        [AsyncStateMachine(typeof(_003CLeaveAlreadyJoinedLobbies_003Ed__124))]
        private Task LeaveAlreadyJoinedLobbies()
        {
            return null;
        }

        protected struct LobbyMember
        {
            public string unityId;

            public string displayName;

            public UserInfo userInfo;

            public LobbyMember(string inUnityId, string inDisplayName, OnlineID inOnlineId, PlatformKeys inPlatformKey)
            {
                unityId = null;
                displayName = null;
                userInfo = default(UserInfo);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CGetUnityAuthIdAsync_003Ed__82 : IAsyncStateMachine
        {
            public int _003C_003E1__state;

            public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

            private TaskAwaiter<bool> _003C_003Eu__1;

            private void MoveNext()
            {
            }

            void IAsyncStateMachine.MoveNext()
            {
                //ILSpy generated this explicit interface implementation from .override directive in MoveNext
                this.MoveNext();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                //ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
                this.SetStateMachine(stateMachine);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CCreateLobbyAsync_003Ed__85 : IAsyncStateMachine
        {
            public int _003C_003E1__state;

            public AsyncTaskMethodBuilder _003C_003Et__builder;

            public Lobby _003C_003E4__this;

            public Dictionary<string, PlayerDataObject> playerData;

            public uint maxSlots;

            private uint _003CerrorCode_003E5__2;

            private TaskAwaiter<string> _003C_003Eu__1;

            private TaskAwaiter<Unity.Services.Lobbies.Models.Lobby> _003C_003Eu__2;

            private TaskAwaiter _003C_003Eu__3;

            private TaskAwaiter<bool> _003C_003Eu__4;

            private void MoveNext()
            {
            }

            void IAsyncStateMachine.MoveNext()
            {
                //ILSpy generated this explicit interface implementation from .override directive in MoveNext
                this.MoveNext();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                //ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
                this.SetStateMachine(stateMachine);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CJoinLobbyAsync_003Ed__88 : IAsyncStateMachine
        {
            public int _003C_003E1__state;

            public AsyncTaskMethodBuilder _003C_003Et__builder;

            public Lobby _003C_003E4__this;

            public string lobbyId;

            public Dictionary<string, PlayerDataObject> playerData;

            public string lobbyCode;

            private string _003CuasId_003E5__2;

            private uint _003CerrorCode_003E5__3;

            private TaskAwaiter<string> _003C_003Eu__1;

            private TaskAwaiter _003C_003Eu__2;

            private TaskAwaiter<Unity.Services.Lobbies.Models.Lobby> _003C_003Eu__3;

            private TaskAwaiter<bool> _003C_003Eu__4;

            private void MoveNext()
            {
            }

            void IAsyncStateMachine.MoveNext()
            {
                //ILSpy generated this explicit interface implementation from .override directive in MoveNext
                this.MoveNext();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                //ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
                this.SetStateMachine(stateMachine);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CLeaveLobbyAsync_003Ed__90 : IAsyncStateMachine
        {
            public int _003C_003E1__state;

            public AsyncTaskMethodBuilder _003C_003Et__builder;

            public Lobby _003C_003E4__this;

            private TaskAwaiter _003C_003Eu__1;

            private void MoveNext()
            {
            }

            void IAsyncStateMachine.MoveNext()
            {
                //ILSpy generated this explicit interface implementation from .override directive in MoveNext
                this.MoveNext();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                //ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
                this.SetStateMachine(stateMachine);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CCheckForLobbyTaskTimeoutAsync_003Ed__96 : IAsyncStateMachine
        {
            public int _003C_003E1__state;

            public AsyncVoidMethodBuilder _003C_003Et__builder;

            public Lobby _003C_003E4__this;

            public int time_ms_AllowedForTask;

            public bool isCreatingLobby;

            private TaskAwaiter _003C_003Eu__1;

            private void MoveNext()
            {
            }

            void IAsyncStateMachine.MoveNext()
            {
                //ILSpy generated this explicit interface implementation from .override directive in MoveNext
                this.MoveNext();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                //ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
                this.SetStateMachine(stateMachine);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CKickUserAsync_003Ed__100 : IAsyncStateMachine
        {
            public int _003C_003E1__state;

            public AsyncTaskMethodBuilder _003C_003Et__builder;

            public string kickTargetId;

            public Lobby _003C_003E4__this;

            private TaskAwaiter _003C_003Eu__1;

            private void MoveNext()
            {
            }

            void IAsyncStateMachine.MoveNext()
            {
                //ILSpy generated this explicit interface implementation from .override directive in MoveNext
                this.MoveNext();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                //ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
                this.SetStateMachine(stateMachine);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CGetLobbyData_003Ed__104 : IAsyncStateMachine
        {
            public int _003C_003E1__state;

            public AsyncTaskMethodBuilder _003C_003Et__builder;

            public Lobby _003C_003E4__this;

            public bool refreshFromRemote;

            private string _003ClocalPlayerUnityId_003E5__2;

            private TaskAwaiter<Unity.Services.Lobbies.Models.Lobby> _003C_003Eu__1;

            private void MoveNext()
            {
            }

            void IAsyncStateMachine.MoveNext()
            {
                //ILSpy generated this explicit interface implementation from .override directive in MoveNext
                this.MoveNext();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                //ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
                this.SetStateMachine(stateMachine);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CBindToRemoteLobbyEvents_003Ed__105 : IAsyncStateMachine
        {
            public int _003C_003E1__state;

            public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

            public string lobbyID;

            public Lobby _003C_003E4__this;

            private TaskAwaiter<ILobbyEvents> _003C_003Eu__1;

            private void MoveNext()
            {
            }

            void IAsyncStateMachine.MoveNext()
            {
                //ILSpy generated this explicit interface implementation from .override directive in MoveNext
                this.MoveNext();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                //ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
                this.SetStateMachine(stateMachine);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003COnLobbyDeleted_003Ed__106 : IAsyncStateMachine
        {
            public int _003C_003E1__state;

            public AsyncVoidMethodBuilder _003C_003Et__builder;

            public Lobby _003C_003E4__this;

            private TaskAwaiter _003C_003Eu__1;

            private void MoveNext()
            {
            }

            void IAsyncStateMachine.MoveNext()
            {
                //ILSpy generated this explicit interface implementation from .override directive in MoveNext
                this.MoveNext();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                //ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
                this.SetStateMachine(stateMachine);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003COnPlayerJoined_003Ed__107 : IAsyncStateMachine
        {
            public int _003C_003E1__state;

            public AsyncVoidMethodBuilder _003C_003Et__builder;

            public List<LobbyPlayerJoined> players;

            public Lobby _003C_003E4__this;

            private void MoveNext()
            {
            }

            void IAsyncStateMachine.MoveNext()
            {
                //ILSpy generated this explicit interface implementation from .override directive in MoveNext
                this.MoveNext();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                //ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
                this.SetStateMachine(stateMachine);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003COnLobbyDataChanged_003Ed__109 : IAsyncStateMachine
        {
            public int _003C_003E1__state;

            public AsyncVoidMethodBuilder _003C_003Et__builder;

            public ILobbyChanges changes;

            public Lobby _003C_003E4__this;

            private List<LobbyMember>.Enumerator _003C_003E7__wrap1;

            private TaskAwaiter _003C_003Eu__1;

            private void MoveNext()
            {
            }

            void IAsyncStateMachine.MoveNext()
            {
                //ILSpy generated this explicit interface implementation from .override directive in MoveNext
                this.MoveNext();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                //ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
                this.SetStateMachine(stateMachine);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CHostHeartbeatPingAsync_003Ed__113 : IAsyncStateMachine
        {
            public int _003C_003E1__state;

            public AsyncTaskMethodBuilder _003C_003Et__builder;

            public Lobby _003C_003E4__this;

            private TaskAwaiter _003C_003Eu__1;

            private Player _003ChostPlayer_003E5__2;

            private List<Player>.Enumerator _003C_003E7__wrap2;

            private void MoveNext()
            {
            }

            void IAsyncStateMachine.MoveNext()
            {
                //ILSpy generated this explicit interface implementation from .override directive in MoveNext
                this.MoveNext();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                //ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
                this.SetStateMachine(stateMachine);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CPlayerUpdatePingAsync_003Ed__114 : IAsyncStateMachine
        {
            public int _003C_003E1__state;

            public AsyncTaskMethodBuilder _003C_003Et__builder;

            public Lobby _003C_003E4__this;

            private TaskAwaiter<Unity.Services.Lobbies.Models.Lobby> _003C_003Eu__1;

            private TaskAwaiter _003C_003Eu__2;

            private void MoveNext()
            {
            }

            void IAsyncStateMachine.MoveNext()
            {
                //ILSpy generated this explicit interface implementation from .override directive in MoveNext
                this.MoveNext();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                //ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
                this.SetStateMachine(stateMachine);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CHeartBeatLoop_003Ed__116 : IAsyncStateMachine
        {
            public int _003C_003E1__state;

            public AsyncTaskMethodBuilder _003C_003Et__builder;

            public Lobby _003C_003E4__this;

            private TaskAwaiter _003C_003Eu__1;

            private void MoveNext()
            {
            }

            void IAsyncStateMachine.MoveNext()
            {
                //ILSpy generated this explicit interface implementation from .override directive in MoveNext
                this.MoveNext();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                //ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
                this.SetStateMachine(stateMachine);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CLeaveLobbyBeforeQuitAsync_003Ed__119 : IAsyncStateMachine
        {
            public int _003C_003E1__state;

            public AsyncVoidMethodBuilder _003C_003Et__builder;

            public Lobby _003C_003E4__this;

            private TaskAwaiter _003C_003Eu__1;

            private void MoveNext()
            {
            }

            void IAsyncStateMachine.MoveNext()
            {
                //ILSpy generated this explicit interface implementation from .override directive in MoveNext
                this.MoveNext();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                //ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
                this.SetStateMachine(stateMachine);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CHostBindPostBoxToRelay_003Ed__120 : IAsyncStateMachine
        {
            public int _003C_003E1__state;

            public AsyncTaskMethodBuilder _003C_003Et__builder;

            public Lobby _003C_003E4__this;

            private TaskAwaiter _003C_003Eu__1;

            private void MoveNext()
            {
            }

            void IAsyncStateMachine.MoveNext()
            {
                //ILSpy generated this explicit interface implementation from .override directive in MoveNext
                this.MoveNext();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                //ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
                this.SetStateMachine(stateMachine);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CPlayerBindPostBoxToRelay_003Ed__121 : IAsyncStateMachine
        {
            public int _003C_003E1__state;

            public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

            public Lobby _003C_003E4__this;

            private TaskAwaiter<bool> _003C_003Eu__1;

            private void MoveNext()
            {
            }

            void IAsyncStateMachine.MoveNext()
            {
                //ILSpy generated this explicit interface implementation from .override directive in MoveNext
                this.MoveNext();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                //ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
                this.SetStateMachine(stateMachine);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CLeaveAlreadyJoinedLobbies_003Ed__124 : IAsyncStateMachine
        {
            public int _003C_003E1__state;

            public AsyncTaskMethodBuilder _003C_003Et__builder;

            private TaskAwaiter<List<string>> _003C_003Eu__1;

            private List<string>.Enumerator _003C_003E7__wrap1;

            private TaskAwaiter _003C_003Eu__2;

            private void MoveNext()
            {
            }

            void IAsyncStateMachine.MoveNext()
            {
                //ILSpy generated this explicit interface implementation from .override directive in MoveNext
                this.MoveNext();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                //ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
                this.SetStateMachine(stateMachine);
            }
        }
    }
}