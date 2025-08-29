using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Unity.Services.Matchmaker.Models;
using Unity.Services.Multiplay;

namespace Coatsink.UnityServices.Matchmaking
{
	public class MultiplayAllocationService : IDisposable
	{
		public enum AllocationState
		{
			None = 0,
			Starting = 1,
			Started = 2
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSubscribeAndAwaitMatchmakerAllocation_003Ed__18 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public MultiplayAllocationService _003C_003E4__this;

			private TaskAwaiter<IServerEvents> _003C_003Eu__1;

			private TaskAwaiter<string> _003C_003Eu__2;

			private TaskAwaiter<MatchmakingResults> _003C_003Eu__3;

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
		private struct _003CAwaitAllocationID_003Ed__19 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			public MultiplayAllocationService _003C_003E4__this;

			private ServerConfig _003Cconfig_003E5__2;

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
		private struct _003CGetMatchmakerAllocationPayloadAsync_003Ed__20 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<MatchmakingResults> _003C_003Et__builder;

			private TaskAwaiter<MatchmakingResults> _003C_003Eu__1;

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

		private string allocationId;

		private readonly IMultiplayService multiplayService;

		private MultiplayEventCallbacks servercallbacks;

		private IServerEvents serverEvents;

		public AllocationState State { get; private set; }

		public event Action<MatchmakingResults> OnMatchmakingResultsReceived
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnMatchmakingResultsError
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Dispose()
		{
		}

		public void StartMatchmakerPayloadQuery()
		{
		}

		[AsyncStateMachine(typeof(_003CSubscribeAndAwaitMatchmakerAllocation_003Ed__18))]
		private void SubscribeAndAwaitMatchmakerAllocation()
		{
		}

		[AsyncStateMachine(typeof(_003CAwaitAllocationID_003Ed__19))]
		private Task<string> AwaitAllocationID()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetMatchmakerAllocationPayloadAsync_003Ed__20))]
		private Task<MatchmakingResults> GetMatchmakerAllocationPayloadAsync()
		{
			return null;
		}

		private void OnMultiplayAllocation(MultiplayAllocation allocation)
		{
		}

		private void OnMultiplayDeAllocation(MultiplayDeallocation deallocation)
		{
		}

		private void OnMultiplayError(MultiplayError error)
		{
		}
	}
}
