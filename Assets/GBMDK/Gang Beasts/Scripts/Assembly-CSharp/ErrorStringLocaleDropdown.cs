using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;

public class ErrorStringLocaleDropdown : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ErrorStringLocaleDropdown _003C_003E4__this;

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
		public _003CStart_003Ed__2(int _003C_003E1__state)
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
	private TMP_Dropdown _dropdown;

	[SerializeField]
	private LanguageSwitcher _languageSwitcher;

	[IteratorStateMachine(typeof(_003CStart_003Ed__2))]
	private IEnumerator Start()
	{
		return null;
	}

	private void LocalizationSettingsOnSelectedLocaleChanged(Locale obj)
	{
	}

	private static void LocaleSelected(int index)
	{
	}

	private void OnDestroy()
	{
	}
}
