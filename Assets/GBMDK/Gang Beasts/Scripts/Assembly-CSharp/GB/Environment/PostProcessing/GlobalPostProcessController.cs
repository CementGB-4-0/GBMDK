using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEditor.PostProcessing;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace GB.Environment.PostProcessing
{
	public class GlobalPostProcessController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CChangeDOF_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GlobalPostProcessController _003C_003E4__this;

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
			public _003CChangeDOF_003Ed__15(int _003C_003E1__state)
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
		private Volume connectedVolume;

		private UnityEngine.Rendering.Universal.DepthOfField storedDepthOfField;

		private float defaultDOFStart;

		private float defaultDOFEnd;

		private float onPauseDOF;

		private float dofTarget;

		private float dofCurrent;

		private Coroutine changeDOFRoutine;

		private WaitForSeconds dofChangeDelay;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void SettingsUpdate(UnityEditor.PostProcessing.GraphicsSettings newSettings)
		{
		}

		private void setDoFOverride(float amount)
		{
		}

		private void FadeDOF(bool shouldFade)
		{
		}

		[IteratorStateMachine(typeof(_003CChangeDOF_003Ed__15))]
		private IEnumerator ChangeDOF()
		{
			return null;
		}
	}
}
