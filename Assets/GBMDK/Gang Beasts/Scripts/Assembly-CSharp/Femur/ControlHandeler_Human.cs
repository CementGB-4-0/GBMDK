using UnityEngine;

namespace Femur
{
	public class ControlHandeler_Human : ControlHandeler
	{
		private enum Arm
		{
			Left = 0,
			Right = 1
		}

		private IControlHandeler_DriveTarget driveTarget;

		private float driveReleaseDelay;

		private bool prepForRelease;

		private const string BODY_HARMFUL_TAG = "Body (Harmful)";

		private const string BODY_HIGH_PRIORITY = "Body (High Priority)";

		private const string VOICEBOX_NAME = "helper_voiceBox";

		private const string UNTAGGED_TAG = "Untagged";

		private float duckTimer;

		private float headbuttDelay;

		private bool validInput;

		private Transform[] _cachedHeadSubObjects;

		private Transform[] _cachedVoiceBoxHeadSubObjects;

		private const float SIT_DELAY = 0.5f;

		private float idleTimeMod;

		private float sitDelay;

		private float legActionDelay;

		private float legActionTimer;

		private Collider leftKickTarget;

		private Collider rightKickTarget;

		private float leftKickTimer;

		private float rightKickTimer;

		private float armActionDelay;

		private float actionDelay;

		private float armActionTimer;

		private float leftArmActionTimer;

		private float rightArmActionTimer;

		private bool grab;

		private bool punch;

		private ConfigurableJoint grabJoint;

		private Rigidbody grabRigidbody;

		private Transform grabTransform;

		private MovementHandeler.Side side;

		private float punchTimer;

		private float leftPunchTimer;

		private float rightPunchTimer;

		private int time;

		private Transform[] CachedHeadSubObjects => null;

		private Transform[] CachedVoiceBoxHeadSubObjects => null;

		public override void ClimbCheck()
		{
		}

		public override void DirectionCheck()
		{
		}

		public override void DriveCheck()
		{
		}

		public override void SetDriveTarget(IControlHandeler_DriveTarget target)
		{
		}

		public override void DuckCheck()
		{
		}

		public override void FallCheck()
		{
		}

		public override void GroundCheck()
		{
		}

		public override void IdleCheck()
		{
		}

		public override void IdleCheckClient()
		{
		}

		public override void JumpRunCheck()
		{
		}

		public override void KickStompCheck()
		{
		}

		public override void LiftCheck()
		{
		}

		public override void PunchGrabCheck()
		{
		}

		private void PunchGrab(Arm arm)
		{
		}

		private bool IsThisArmHeldDown(Arm arm)
		{
			return false;
		}

		private bool IsThisArmJustUp(Arm arm)
		{
			return false;
		}

		private bool IsThisArmJustDown(Arm arm)
		{
			return false;
		}

		public override void ResetVariables()
		{
		}

		public override void ReviveCheck()
		{
		}

		public override void RunCheck()
		{
		}

		public override void SwimCheck()
		{
		}
	}
}
