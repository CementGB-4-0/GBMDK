using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GB
{
	public class WheelEscalation : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDoFrameEscalation_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public WheelEscalation _003C_003E4__this;

			private int _003CframePiecesToBreak_003E5__2;

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
			public _003CDoFrameEscalation_003Ed__38(int _003C_003E1__state)
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
		private sealed class _003CDoSpeedEscalation_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public WheelEscalation _003C_003E4__this;

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
			public _003CDoSpeedEscalation_003Ed__39(int _003C_003E1__state)
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
		private sealed class _003CDoCarriageEscalation_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public WheelEscalation _003C_003E4__this;

			private int _003CcarriagesToBreak_003E5__2;

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
			public _003CDoCarriageEscalation_003Ed__40(int _003C_003E1__state)
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

		[SerializeField]
		[Header("Shared")]
		public float EscalationTime;

		[SerializeField]
		public float SecondEscalationTime;

		[SerializeField]
		public float FinalEscalationTime;

		private float nextEscalationTime;

		[SerializeField]
		private wheelAxle AxleRef;

		private float roundTimer;

		private bool timerStarted;

		[HideInInspector]
		public float frameMalfunctionChance;

		[SerializeField]
		[Space]
		[Header("Frame Malfunction")]
		private List<Rigidbody> PotentialFrameBreaks;

		[SerializeField]
		private AudioClip frameEscalationStartClip;

		[SerializeField]
		private ParticleAutoDisable frameEscalationStartParticleEffect;

		[SerializeField]
		private int MinimumBreakFramePieces;

		[SerializeField]
		private int MaximumBreakFramePieces;

		[SerializeField]
		private float MinimumBreakFrameDelay;

		[SerializeField]
		private float MaximumBreakFrameDelay;

		[HideInInspector]
		public float speedMalfunctionChance;

		[Space]
		[Header("Speed Malfunction")]
		[SerializeField]
		private AudioClip speedEscalationStartClip;

		[SerializeField]
		private ParticleAutoDisable speedEscalationStartParticleEffect;

		[SerializeField]
		private float SpeedMultiplier;

		[SerializeField]
		private float ForceMultiplier;

		[HideInInspector]
		public float carriageMalfunctionChance;

		[SerializeField]
		[Header("Carriage Malfunction")]
		[Space]
		private List<Rigidbody> CarriageRefs;

		[SerializeField]
		private AudioClip carriageEscalationStartClip;

		[SerializeField]
		private ParticleAutoDisable carriageEscalationStartParticleEffect;

		[SerializeField]
		private int MinimumCarriagesToBreak;

		[SerializeField]
		private int MaximumCarriagesToBreak;

		[SerializeField]
		private float MinimumCarriageBreakDelay;

		[SerializeField]
		private float MaximumCarriageBreakDelay;

		[SerializeField]
		private int[] escalationOrder;

		private int currentEscalationIndex;

		public void SetFrameMalfunctionChance(float newChance)
		{
		}

		public void SetSpeedMalfunctionChance(float newChance)
		{
		}

		public void SetCarriageMalfunctionChance(float newChance)
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		private void BeginTimer()
		{
		}

		private void SelectAndStartEscalation()
		{
		}

		[IteratorStateMachine(typeof(_003CDoFrameEscalation_003Ed__38))]
		private IEnumerator DoFrameEscalation()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDoSpeedEscalation_003Ed__39))]
		private IEnumerator DoSpeedEscalation()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDoCarriageEscalation_003Ed__40))]
		private IEnumerator DoCarriageEscalation()
		{
			return null;
		}
	}
}
