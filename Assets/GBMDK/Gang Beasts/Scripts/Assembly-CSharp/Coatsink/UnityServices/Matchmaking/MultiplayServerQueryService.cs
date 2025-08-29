using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Unity.Services.Multiplay;

namespace Coatsink.UnityServices.Matchmaking
{
	public class MultiplayServerQueryService : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CBeginServerQueryHandler_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public MultiplayServerQueryService _003C_003E4__this;

			private TaskAwaiter<IServerQueryHandler> _003C_003Eu__1;

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
		private struct _003CServerQueryLoop_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public MultiplayServerQueryService _003C_003E4__this;

			public CancellationToken cancellationToken;

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

		private IMultiplayService multiplayService;

		private IServerQueryHandler serverQueryHandler;

		private CancellationTokenSource serverCheckCancel;

		[AsyncStateMachine(typeof(_003CBeginServerQueryHandler_003Ed__4))]
		public Task BeginServerQueryHandler()
		{
			return null;
		}

		public void SetServerName(string name)
		{
		}

		public void SetBuildId(string id)
		{
		}

		public void SetPort(ushort port)
		{
		}

		public void SetMaxPlayers(ushort players)
		{
		}

		public ushort GetMaxPlayers()
		{
			return 0;
		}

		public void SetPlayerCount(ushort count)
		{
		}

		public void AddPlayer()
		{
		}

		public void RemovePlayer()
		{
		}

		public void SetMap(string newMap)
		{
		}

		public void SetMode(string mode)
		{
		}

		[AsyncStateMachine(typeof(_003CServerQueryLoop_003Ed__15))]
		private Task ServerQueryLoop(CancellationToken cancellationToken)
		{
			return null;
		}

		public void Dispose()
		{
		}
	}
}
