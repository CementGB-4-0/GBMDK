using UnityEngine;

namespace Femur
{
	public class ControlHandeler
	{
		public enum AgentAreaMask
		{
			jump = 2,
			Climb = 4
		}

		public Transform localTransform;

		public Actor actor;

		public Vector3 direction;

		public Vector3 rawDirection;

		public bool onGround;

		public float offGroundDelay;

		public float groundCheckDelay;

		public bool onMovingPlatform;

		public Transform currentMovingPlatform;

		public bool leftCanClimb;

		public bool rightCanClimb;

		public bool inWater;

		public float swimCheckDelay;

		public Vector3 velocity;

		public float smoothTime;

		public Vector3 lookDirection;

		public Vector3 drivingLookDirection;

		public Vector3 moveDirection;

		public Vector3 lockedDirection;

		public bool leftArmOverride;

		public bool rightArmOverride;

		public bool leftLegOverride;

		public bool rightLegOverride;

		public float jumpDelay;

		public bool leftGrab;

		public bool rightGrab;

		public bool leftPunch;

		public bool rightPunch;

		public bool lift;

		public bool liftSelf;

		public bool jump;

		public bool grabJump;

		public float grabJumpCounter;

		public bool duck;

		public bool leftKick;

		public bool rightKick;

		public bool kickDuck;

		public bool backFlip;

		public float grabDelay;

		public float reviveDelay;

		public float idleTimer;

		public float liftTimer;

		public bool run;

		public float runTimer;

		public float jumpTimer;

		public float fallTimer;

		public Vector3 slideDirection;

		public bool canDive;

		public bool headbutt;

		public float headbuttTimer;

		public bool ForceUpdate;

		public bool dropkickFix;

		public bool burning;

		public bool driving;

		protected float GetAnalogInput(string key)
		{
			return 0f;
		}

		protected bool GetDigitalInput(string key)
		{
			return false;
		}

		protected bool GetDigitalInputJustDown(string key)
		{
			return false;
		}

		protected bool GetDigitalInputJustUp(string key)
		{
			return false;
		}

		public void GetInput()
		{
		}

		public virtual void DirectionCheck()
		{
		}

		public virtual void GroundCheck()
		{
		}

		public virtual void FallCheck()
		{
		}

		public virtual void PunchGrabCheck()
		{
		}

		public virtual void KickStompCheck()
		{
		}

		public virtual void RunCheck()
		{
		}

		public virtual void JumpRunCheck()
		{
		}

		public virtual void DuckCheck()
		{
		}

		public virtual void LiftCheck()
		{
		}

		public virtual void ClimbCheck()
		{
		}

		public virtual void ResetVariables()
		{
		}

		public virtual void ReviveCheck()
		{
		}

		public virtual void IdleCheck()
		{
		}

		public virtual void SwimCheck()
		{
		}

		public virtual void DriveCheck()
		{
		}

		public virtual void IdleCheckClient()
		{
		}

		public virtual void SetDriveTarget(IControlHandeler_DriveTarget target)
		{
		}

		public void InputSpamCheck()
		{
		}
	}
}
