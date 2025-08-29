using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Services.Matchmaker;
using Unity.Services.Matchmaker.Models;

namespace Coatsink.UnityServices.Matchmaking
{
	public class MatchmakingManager
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSendMatchRequest_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public MatchmakingManager _003C_003E4__this;

			public List<Player> players;

			public CreateTicketOptions ticketOptions;

			private TaskAwaiter<MatchmakingResult> _003C_003Eu__1;

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

		private UnityMatchmakerWrapper matchmakingWrapper;

		private Action<MatchmakingResult> onMatchmakingComplete;

		public void Dispose()
		{
		}

		private void TriggerMatchmakingComplete(MatchmakingResult result, Action<MatchmakingResult> onComplete)
		{
		}

		public void StartMatchmaking(List<MMPlayer> players, CreateTicketOptions ticketOptions, Action<MatchmakingResult> OnComplete)
		{
		}

		public void StartMatchmakingQos(List<MMPlayer> players, CreateTicketOptions ticketOptions, Action<MatchmakingResult> onComplete)
		{
		}

		private void StartMatchmakingInternal(List<Player> players, CreateTicketOptions ticketOptions, Action<MatchmakingResult> onComplete)
		{
		}

		public void CancelMatchmaking()
		{
		}

		[AsyncStateMachine(typeof(_003CSendMatchRequest_003Ed__9))]
		private void SendMatchRequest(List<Player> players, CreateTicketOptions ticketOptions)
		{
		}
	}
}
