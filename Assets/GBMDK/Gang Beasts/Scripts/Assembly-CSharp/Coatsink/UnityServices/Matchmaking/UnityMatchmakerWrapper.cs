using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Unity.Services.Matchmaker;
using Unity.Services.Matchmaker.Models;

namespace Coatsink.UnityServices.Matchmaking
{
	public class UnityMatchmakerWrapper : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStartMatchmaking_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<MatchmakingResult> _003C_003Et__builder;

			public UnityMatchmakerWrapper _003C_003E4__this;

			public List<Player> players;

			public CreateTicketOptions options;

			private TaskAwaiter<CreateTicketResponse> _003C_003Eu__1;

			private TaskAwaiter<TicketStatusResponse> _003C_003Eu__2;

			private TaskAwaiter _003C_003Eu__3;

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
		private struct _003CCancelMatchmaking_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public UnityMatchmakerWrapper _003C_003E4__this;

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

		private string lastUsedTicket;

		private bool isMatchmaking;

		private CancellationTokenSource cancelToken;

		private const int getTicketCooldown = 1000;

		public bool IsMatchmaking => false;

		[AsyncStateMachine(typeof(_003CStartMatchmaking_003Ed__6))]
		public Task<MatchmakingResult> StartMatchmaking(List<Player> players, CreateTicketOptions options)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCancelMatchmaking_003Ed__7))]
		public Task CancelMatchmaking()
		{
			return null;
		}

		private MatchmakingResult ReturnMatchResult(MatchmakingState resultErrorType, string message = "", MultiplayAssignment assignment = null)
		{
			return default(MatchmakingResult);
		}

		public void Dispose()
		{
		}
	}
}
