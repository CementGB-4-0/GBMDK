using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Femur;
using GB.Utils;
using UnityEngine;

namespace GB.Achievements
{
	[Serializable]
	public class PostCondition
	{
		[Serializable]
		public delegate bool Condition(Actor beastRef);

		[Serializable]
		public delegate void Response(bool status, Actor beastRef);

		[CompilerGenerated]
		private sealed class _003CCheckContinualCondition_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PostCondition _003C_003E4__this;

			public Actor beastRef;

			private float _003CstartTimer_003E5__2;

			private bool _003CshouldLoop_003E5__3;

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
			public _003CCheckContinualCondition_003Ed__22(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass23_0
		{
			public PostCondition _003C_003E4__this;

			public Actor beastRef;

			internal bool _003CWaitUntilCondition_003Eb__0()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CWaitUntilCondition_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PostCondition _003C_003E4__this;

			public Actor beastRef;

			private _003C_003Ec__DisplayClass23_0 _003C_003E8__1;

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
			public _003CWaitUntilCondition_003Ed__23(int _003C_003E1__state)
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

		public Condition ConditionPredicate;

		public string ConditionHumanName;

		[SerializeField]
		public ConditionArchtypes ConditionType;

		public Actor.ActorState targetState;

		public bool targetStateValue;

		public GameObject targetObject;

		public Collider targetArea;

		public bool targetShouldBeIn;

		public bool targetStartsIn;

		private bool objectCurrentlyPresent;

		private TriggerDetection heldTrigRef;

		[SerializeField]
		[Tooltip("How long this condition should check for")]
		public float Timer;

		[Tooltip("A Permanence condition must always be met to pass - \r\n a non-Permanence condition must only be met at the end of the timeout.")]
		[SerializeField]
		public bool Permanence;

		[SerializeField]
		[Tooltip("Check for target beast state continuously until it has been met or until beast is dead.")]
		public bool ContinuouslyCheckTargetState;

		private Response onComplete;

		public PostCondition(string friendlyName, ConditionArchtypes type, float timer, bool permanence = false, bool checkContinuously = false)
		{
		}

		public void Initialise()
		{
		}

		public void StartCondition(Response response, Actor beastRef)
		{
		}

		private void RecreateDelegate(Actor beastRef)
		{
		}

		private void CheckCondition(Actor beastRef)
		{
		}

		[IteratorStateMachine(typeof(_003CCheckContinualCondition_003Ed__22))]
		private IEnumerator CheckContinualCondition(Actor beastRef)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CWaitUntilCondition_003Ed__23))]
		private IEnumerator WaitUntilCondition(Actor beastRef)
		{
			return null;
		}
	}
}
