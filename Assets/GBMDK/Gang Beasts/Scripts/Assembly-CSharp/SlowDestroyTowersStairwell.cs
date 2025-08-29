using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;

public class SlowDestroyTowersStairwell : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CBreakStairsLogic_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SlowDestroyTowersStairwell _003C_003E4__this;

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
		public _003CBreakStairsLogic_003Ed__34(int _003C_003E1__state)
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
	private sealed class _003CPlayCreakingSounds_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SlowDestroyTowersStairwell _003C_003E4__this;

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
		public _003CPlayCreakingSounds_003Ed__35(int _003C_003E1__state)
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

	public Joint jointA;

	public Rigidbody rigidbodyA;

	public float delayA;

	public Joint jointB;

	public Rigidbody rigidbodyB;

	public float delayB;

	public Joint jointC;

	public Rigidbody rigidbodyC;

	public float delayC;

	public Joint jointD;

	public Rigidbody rigidbodyD;

	public float delayD;

	public float breakingJointsVolume;

	public Joint[] otherJoints;

	[SerializeField]
	[HideInInspector]
	private Rigidbody[] otherJointsBody;

	public float minBreakGap;

	public float maxBreakGap;

	public AudioMixerGroup mixerGroup;

	private float breakTimer;

	private float breakTime;

	public SceneAudioClip creakingSound;

	public AudioClip[] creakingAudioClips;

	public Transform breakingPosition;

	public AudioClip[] breakingAudioClips;

	public float minVariance;

	public float maxVariance;

	private bool hasTriggered;

	private bool lastBreakHappend;

	private bool playCreakingSoundsOnce;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider collider)
	{
	}

	private void BreakJoint(Joint target, Rigidbody body, bool setAngular)
	{
	}

	[ContextMenu("Break")]
	private void BreakStairs()
	{
	}

	[IteratorStateMachine(typeof(_003CBreakStairsLogic_003Ed__34))]
	private IEnumerator BreakStairsLogic()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPlayCreakingSounds_003Ed__35))]
	private IEnumerator PlayCreakingSounds()
	{
		return null;
	}

	private void BreakRandomJoint()
	{
	}

	private void OnValidate()
	{
	}
}
