using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Coatsink.Platform;
using Coatsink.Platform.Systems.Online;
using Coatsink.Platform.Systems.User;
using CS.CorePlatform;
using CS.CorePlatform.Base.Client.Part;
using CS.CorePlatform.Utils.Data;
using Unity.Networking.Transport;
using Unity.Services.Relay.Models;

namespace GangBeastsUnityLobby.Platform
{
    public class RelayPostBox : BasePostBox<UserInfo>
    {
        private const string NET_PROTOCOL = "dtls";

        private const int MESSAGE_MAX_SIZE = 2048;

        private const int _connectionRetrys = 5;

        private const int MAX_CONNECTION_COUNT = 10;

        public BasePlatformManager PlatformManager;

        private NetworkConnection _clientConnection;

        private Allocation _hostAllocation;

        private bool _hostConnectionSuccesful;

        private NetworkDriver _hostDriver;

        private int _lastReceivedConnectionId;

        private Queue<IncomingMessage> _messageQueue;

        private byte[] _messageReader;

        private Action<Guid, string> _onBindComplete;

        private JoinAllocation _playerAllocation;

        private bool _playerConnectionSuccesful;

        private NetworkDriver _playerDriver;

        private NetworkPipeline _reliablePipeline;

        private List<NetworkConnection> _serverConnections;

        public Action OnReceivedHostConfirmation;

        public Lobby UnityLobbyHandler;

        private void OnDestroy()
        {
        }

        [AsyncStateMachine(typeof(_003CHostCreateAllocation_003Ed__21))]
        public Task HostCreateAllocation(TaskResult<ILobby> taskResult, Action<Guid, string> onBindFinished = null)
        {
            return null;
        }

        [AsyncStateMachine(typeof(_003CHostBindToRelay_003Ed__22))]
        public Task HostBindToRelay()
        {
            return null;
        }

        public void UpdateHost()
        {
        }

        private void RerouteMessageToAllClients(byte[] message, UserInfo originalSender, int senderConnectionId)
        {
        }

        [AsyncStateMachine(typeof(_003CPlayerJoinAllocation_003Ed__25))]
        public Task<bool> PlayerJoinAllocation(string joinCode, Action<Guid, string> onBindFinished = null)
        {
            return null;
        }

        public void OnBindPlayer()
        {
        }

        public void UpdatePlayer()
        {
        }

        private void WriteMessageToDataStream(string senderUnityId, byte[] message, ref DataStreamWriter writer)
        {
        }

        public override void SendNewMessage(UserInfo userID, byte[] message, int size, bool reliable)
        {
        }

        protected override bool GetMessage(ref UserInfo senderID, out DataReader message)
        {
            message = null;
            return false;
        }

        protected override void ParseMessage(UserInfo senderID, DataReader message)
        {
        }

        private BaseUserInfo MakeBaseUserInfoFromUserInfo(UserInfo senderID)
        {
            return default(BaseUserInfo);
        }

        public void DisconnectFromRelay()
        {
        }

        protected struct IncomingMessage
        {
            public int connectionId;

            public DataStreamReader stream;

            public IncomingMessage(int inConnectionId, DataStreamReader inStream)
            {
                connectionId = 0;
                stream = default(DataStreamReader);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CHostCreateAllocation_003Ed__21 : IAsyncStateMachine
        {
            public int _003C_003E1__state;

            public AsyncTaskMethodBuilder _003C_003Et__builder;

            public RelayPostBox _003C_003E4__this;

            public Action<Guid, string> onBindFinished;

            public TaskResult<ILobby> taskResult;

            private TaskAwaiter<Allocation> _003C_003Eu__1;

            private int _003Ci_003E5__2;

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
        private struct _003CHostBindToRelay_003Ed__22 : IAsyncStateMachine
        {
            public int _003C_003E1__state;

            public AsyncTaskMethodBuilder _003C_003Et__builder;

            public RelayPostBox _003C_003E4__this;

            private TaskAwaiter<string> _003C_003Eu__1;

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
        private struct _003CPlayerJoinAllocation_003Ed__25 : IAsyncStateMachine
        {
            public int _003C_003E1__state;

            public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

            public string joinCode;

            public RelayPostBox _003C_003E4__this;

            public Action<Guid, string> onBindFinished;

            private TaskAwaiter<JoinAllocation> _003C_003Eu__1;

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