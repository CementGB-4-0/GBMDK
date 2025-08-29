using System.Runtime.InteropServices;
using Audio;
using UnityEngine;
using UnityEngine.Networking;

namespace GB.Stages.Vents
{
	[RequireComponent(typeof(Animator))]
	public class FanController : NetworkBehaviour
	{
		private enum FanState
		{
			NotSpinning = 0,
			Clockwise = 1,
			Anticlockwise = 2
		}

		private const string FAN_START_TRIGGER = "StartSpinning";

		private const string FAN_STOP_TRIGGER = "StopSpinning";

		[SerializeField]
		private Transform audioSourcePlayTransform;

		[SerializeField]
		private AudioClip[] _fanActiveSounds;

		[SerializeField]
		private float _fanActiveVolume;

		[SerializeField]
		private AudioClip[] _fanChangeSounds;

		[SerializeField]
		private float _fanChangeVolume;

		[SerializeField]
		private AudioClip _fanOnOneShot;

		[SerializeField]
		private float _fanOnOneShotVolume;

		[SerializeField]
		private AudioClip _fanOffOneShot;

		[SerializeField]
		private float _fanOffOneShotVolume;

		private AudioController.PooledAudioSource _fanLoopSource;

		[SerializeField]
		private float _gravityMultiplayer;

		[Tooltip("Reference to the effector field tied to the fan animation - affects beasts only")]
		[SerializeField]
		private PushVolume _beastEffectorVolume;

		[Tooltip("The magnitude of force to be applied by the effector field - affects beasts only")]
		[SerializeField]
		private float _beastVolumeThrustMagnitude;

		[SerializeField]
		[Tooltip("Reference to the effector field tied to the fan animation - affects everything but beasts")]
		private PushVolume _nonBeastEffectorVolume;

		[Tooltip("The magnitude of force to be applied by the effector field - affects everything but beasts")]
		[SerializeField]
		private float _nonBeastVolumeThrustMagnitude;

		private Animator _animatorRef;

		private bool _nextSpinClockwise;

		[SyncVar(hook = "OnTriggerMoveSync")]
		private bool _shouldTriggerFanMove;

		private bool _localTriggeredFanMove;

		[SyncVar(hook = "OnTriggerStopSync")]
		private bool _shouldTriggerFanStop;

		private bool _localTriggeredFanStop;

		[SyncVar(hook = "OnAnimationSpeedChange")]
		private float _animationSpeed;

		[SerializeField]
		private float FanSpinTime;

		[SerializeField]
		private float FanWindupTime;

		[SerializeField]
		private float FanDisabledTime;

		[SerializeField]
		private float FanSpinSpeed;

		[Tooltip("How fast the fan should spin while turned off, expressed as a decimal percentage of the main spin speed")]
		[SerializeField]
		private float FanOffLazySpinPercent;

		[Tooltip("At what percentage speed should the force effectors switch off?")]
		[SerializeField]
		private float FanSpeedPercentCutoff;

		private float _animationActiveTimer;

		private FanState _currentFanState;

		private bool _nextSpinCW;

		private bool _needsInitialFlip;

		private bool _stoppedForces;

		private float _flipSoundDelayCounter;

		private bool wasPaused;

		[SyncVar(hook = "OnSpeedChanged")]
		private float FanSpeedTValue;

		private static int kRpcRpc_TriggerCWFlip;

		private static int kRpcRpc_TriggerACFlip;

		private static int kRpcRpc_NotifyFanStarted;

		private static int kRpcRpc_NotifyFanStopped;

		public bool Network_shouldTriggerFanMove
		{
			get
			{
				return false;
			}
			[param: In]
			set
			{
			}
		}

		public bool Network_shouldTriggerFanStop
		{
			get
			{
				return false;
			}
			[param: In]
			set
			{
			}
		}

		public float Network_animationSpeed
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		public float NetworkFanSpeedTValue
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		private void OnTriggerMoveSync(bool value)
		{
		}

		private void OnTriggerStopSync(bool value)
		{
		}

		private void OnAnimationSpeedChange(float value)
		{
		}

		private void OnSpeedChanged(float value)
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void FixedUpdate()
		{
		}

		[ClientRpc]
		public void Rpc_TriggerCWFlip()
		{
		}

		private void CWFlip()
		{
		}

		[ClientRpc]
		public void Rpc_TriggerACFlip()
		{
		}

		private void ACFlip()
		{
		}

		[ClientRpc]
		public void Rpc_NotifyFanStarted()
		{
		}

		[ClientRpc]
		public void Rpc_NotifyFanStopped()
		{
		}

		private void CheckAnimTriggers()
		{
		}

		private void TriggerNextAnimationSegment()
		{
		}

		private void TriggerNextAnimStop()
		{
		}

		private void StartClockwiseAnimation()
		{
		}

		private void StartAnticlockwiseAnimation()
		{
		}

		private void StopAnimation()
		{
		}

		public void ReceiveRotationStopped()
		{
		}

		public void ReceiveRotationStarted()
		{
		}

		private void UNetVersion()
		{
		}

		protected static void InvokeRpcRpc_TriggerCWFlip(NetworkBehaviour obj, NetworkReader reader)
		{
		}

		protected static void InvokeRpcRpc_TriggerACFlip(NetworkBehaviour obj, NetworkReader reader)
		{
		}

		protected static void InvokeRpcRpc_NotifyFanStarted(NetworkBehaviour obj, NetworkReader reader)
		{
		}

		protected static void InvokeRpcRpc_NotifyFanStopped(NetworkBehaviour obj, NetworkReader reader)
		{
		}

		public void CallRpc_TriggerCWFlip()
		{
		}

		public void CallRpc_TriggerACFlip()
		{
		}

		public void CallRpc_NotifyFanStarted()
		{
		}

		public void CallRpc_NotifyFanStopped()
		{
		}

		static FanController()
		{
		}

		public override bool OnSerialize(NetworkWriter writer, bool forceAll)
		{
			return false;
		}

		public override void OnDeserialize(NetworkReader reader, bool initialState)
		{
		}

		public override void PreStartClient()
		{
		}
	}
}
