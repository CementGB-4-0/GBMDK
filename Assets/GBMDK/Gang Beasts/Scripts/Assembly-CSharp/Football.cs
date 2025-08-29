using Femur;
using GB.Networking.Utils.Spawn;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Serialization;

public class Football : NetworkBehaviour
{
	private Transform targetTransform;

	private Transform thisTransform;

	private Rigidbody thisRigidbody;

	private MeshRenderer thisRenderer;

	private Vector3 cachedScale;

	public Collider thisCollider;

	private Actor actor;

	[FormerlySerializedAs("particleSystem")]
	public ParticleSystem ballParticleSystem;

	public AudioClip[] popClip;

	public AudioClip[] raspClip;

	private bool popped;

	private InteractableObject interactableObject;

	private GBSpawnPoint spawnPoint;

	private bool kick;

	private bool head;

	private float power;

	private float resetDelay;

	private Vector3 lastDirection;

	private float verticalForceDamperTimer;

	public CMTargetObject CameraHelperTarget;

	private Vector3 _CamResetVelocity;

	private bool _ResetCamera;

	private bool _isGoldenBall;

	private float _shrinkRateXZ;

	private float _shrinkRateY;

	private float _goldenShrinkRateXZ;

	private float _goldenShrinkRateY;

	public Material defaultMaterial;

	public Material overtimeMaterial;

	private static int kRpcRpcSetBallColor;

	private static int kRpcRpcOnBallPopped;

	private static int kRpcRpcOnResetBall;

	public bool HasPopped => false;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	public void SetSpawnPoint(GBSpawnPoint spawn)
	{
	}

	private void OnTriggerStay(Collider collider)
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	[ContextMenu("Pop Ball")]
	public void PopBall()
	{
	}

	public void FocusOnResetPosition()
	{
	}

	public void InitCameraTracking()
	{
	}

	public void DisableCameraTracking()
	{
	}

	public void EnableCameraTracking()
	{
	}

	public void ResetBall(bool overtime)
	{
	}

	[ClientRpc]
	private void RpcSetBallColor(bool overtime)
	{
	}

	[ClientRpc]
	private void RpcOnBallPopped()
	{
	}

	[ClientRpc]
	private void RpcOnResetBall()
	{
	}

	private void UNetVersion()
	{
	}

	protected static void InvokeRpcRpcSetBallColor(NetworkBehaviour obj, NetworkReader reader)
	{
	}

	protected static void InvokeRpcRpcOnBallPopped(NetworkBehaviour obj, NetworkReader reader)
	{
	}

	protected static void InvokeRpcRpcOnResetBall(NetworkBehaviour obj, NetworkReader reader)
	{
	}

	public void CallRpcSetBallColor(bool overtime)
	{
	}

	public void CallRpcOnBallPopped()
	{
	}

	public void CallRpcOnResetBall()
	{
	}

	static Football()
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
