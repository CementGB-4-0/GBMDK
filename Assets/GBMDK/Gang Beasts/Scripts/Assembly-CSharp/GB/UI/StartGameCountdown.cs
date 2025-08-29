using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GB.Platform.Lobby;
using GB.UI.Beasts;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace GB.UI
{
	public class StartGameCountdown : MonoBehaviour
	{
		[Serializable]
		public class StringEvent : UnityEvent
		{
		}

		[CompilerGenerated]
		private sealed class _003CCountdown_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public StartGameCountdown _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCountdown_003Ed__26(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public StringEvent Complete;

		public StringEvent Start;

		public StringEvent Terminated;

		[SerializeField]
		private UnityEvent OnTimerStart;

		[SerializeField]
		private UnityEvent OnTimerEnded;

		[SerializeField]
		private bool _resetOnStart;

		private float _countdownTimer;

		private float _currentCountdown;

		private Coroutine _countdownCoroutine;

		public bool CountdownActive => false;

		public event Action<float> OnTimerChanged
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

		public event Action<bool> OnTimerActive
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

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void TeamChanged(LocalPlayerInfomationCache player, int old)
		{
		}

		private void PlatformEvents_OnMainUserStateEvent(bool effect)
		{
		}

		private void OnControllerDisconnected(in InputDevice device, int userIndex)
		{
		}

		private void StateChanged(LocalPlayerInfomationCache player, BeastUtils.PlayerState old)
		{
		}

		private void SettingChanged()
		{
		}

		public void StartTimer()
		{
		}

		[IteratorStateMachine(typeof(_003CCountdown_003Ed__26))]
		private IEnumerator Countdown()
		{
			return null;
		}

		public void TerminateTimer()
		{
		}

		public void StopTimer()
		{
		}
	}
}
