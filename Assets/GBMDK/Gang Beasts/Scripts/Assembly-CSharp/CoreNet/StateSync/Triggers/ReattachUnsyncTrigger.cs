using System.Collections.Generic;
using Femur;
using UnityEngine;

namespace CoreNet.StateSync.Triggers
{
	public class ReattachUnsyncTrigger : BaseSyncTrigger
	{
		private const float HAT_RETACH_DELAY = 1f;

		private const float TRIGGER_RECHECK_TIME = 0.1f;

		[SerializeField]
		private Collider reattachTrigger;

		[SerializeField]
		private BodyEnum listenBodyPart;

		[SerializeField]
		private float anglePitchTolerance;

		[SerializeField]
		private float angleYawTolerance;

		[SerializeField]
		private float angleRollTolerance;

		[SerializeField]
		[Tooltip("If a hat is not correctly oriented by default, set it's local forward here")]
		private Vector3 hatLocalForward;

		[Tooltip("if a hat is not correcly oriented by default, set it's local up here")]
		[SerializeField]
		private Vector3 hatLocalUp;

		[SerializeField]
		[Tooltip("How far this hat should snap down after being re-attached. Usually the distance between the bottom of the trigger area, and the top of the wearable hat area")]
		private float reparentDownshift;

		private float detachTime;

		private float lastUpdateTime;

		private Rigidbody selfRB;

		private JointCache[] cachedJoints;

		private List<Actor> beastsInArea;

		public void Start()
		{
		}

		private void Update()
		{
		}

		public override void OverrideSync(bool state)
		{
		}

		private void OnBeastEnter(Actor beast)
		{
		}

		private void OnBeastExit(Actor beast)
		{
		}

		private void OnJointBreak(float breakForce)
		{
		}

		private void CheckBeastRotation(Actor beast)
		{
		}
	}
}
