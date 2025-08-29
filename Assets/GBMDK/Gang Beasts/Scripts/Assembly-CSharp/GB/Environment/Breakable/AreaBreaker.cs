using System.Collections.Generic;
using UnityEngine;

namespace GB.Environment.Breakable
{
	public class AreaBreaker : MonoBehaviour
	{
		[SerializeField]
		private bool _onLeave;

		[SerializeField]
		private bool _onEnter;

		[SerializeField]
		private List<MonoBehaviour> _onlySelected;

		[HideInInspector]
		[SerializeField]
		private List<Collider> _onlyAccept;

		private List<IBreakable> _onlyEffect;

		private void Awake()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void TriggerBreak(Collider other)
		{
		}

		private void OnValidate()
		{
		}

		[ContextMenu("Register family IBreakables")]
		private void EDITOR_RegisterFamily()
		{
		}
	}
}
