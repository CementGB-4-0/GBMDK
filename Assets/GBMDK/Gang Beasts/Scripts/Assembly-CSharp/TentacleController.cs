using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class TentacleController : MonoBehaviour
{
	public TentacleSegment[] segments;

	public TentacleSegment RootSegment;

	public TentacleSegment TipSegment;

	[Header("Physics Settings")]
	public float idleForce;

	public float attackForce;

	public float retreteForce;

	public float upForce;

	public float shrugForce;

	public float maxVelocity;

	public float maxAngularVelocity;

	public Collider splashAudioCollider;

	[Header("Move Position Speed")]
	public float IdlePosMoveFactor;

	public float AttackPosMoveFactor;

	public float RetreatPosMoveFactor;

	public float FlailPosMoveFactor;

	public float MoveFactorVariation;

	[Header("Targeting Settings")]
	public Transform searchArea;

	public float searchRadius;

	public Rigidbody targetedTarget;

	public Vector3 enviromentTarget;

	[Header("Flail Target Settings")]
	public Vector3 flailTarget;

	public Transform flailTargetSearchCenter;

	public float flailRadius;

	public bool drawFlailTargetArea;

	public LayerMask FlailTargetLayerMask;

	public float flailInterestTime;

	private float flailInterestTimer;

	[Header("Position Settings")]
	public Vector3 disabledPosition;

	public Vector3 idlePosition;

	public Vector3 attackPosition;

	public Vector3 retretePosition;

	public float MoveThreshold;

	[Header("Grab Settings")]
	public LayerMask ActorTargettingLayerMask;

	public LayerMask EnvironmentTargetingLayerMask;

	public float playerGripStrength;

	public float environmentGripStrength;

	public float releaseHeight;

	public float throwHeight;

	public float minGrabHeight;

	public float ForceReleaseTime;

	public float DragReleaseChanceTimer;

	public float FlailReleaseChanceTimer;

	public float ReleaseTimerVariance;

	public float throwStrengthMultiplier;

	private float releaseTimer;

	private float objectHeldTimer;

	[HideInInspector]
	public bool hasObject;

	[HideInInspector]
	public bool objectIsActor;

	public GeneralAudioData grabAudioData;

	[Header("Aggression Settings")]
	public float idleTime;

	public float attackTime;

	public float flailTime;

	public float retreatingTime;

	public float dragToDepthsTime;

	[Range(0f, 100f)]
	public float targetedAttackChance;

	public float InterestTime;

	[Description("Kill (retreating in the depths) is tied to aggression this is added to the range to give a chance of leaving the player alone")]
	public float forgivePlayerChance;

	public float releaseTargetChance;

	[Header("Idle")]
	[Header("Tranistion Chance Settings")]
	public float IdleToFlail;

	[Header("Attack Target")]
	public float TargetToFlail;

	[Header("Attack Environment")]
	public float EnvToFlail;

	[Header("Flail")]
	public float FlailToFlail;

	[Header("Status")]
	public TentacleControllerState state;

	public TentacleControllerState lastState;

	public float stateTimer;

	[Header("Debug")]
	public bool InDebug;

	public bool DebugTargets;

	public bool DebugPositions;

	public bool DebugForces;

	private Collider[] _hitColliders;

	private int _collidersFound;

	private List<Rigidbody> targets;

	private Vector3 oldEnviromentTarget;

	private Vector3 newEnviromentTarget;

	private RaycastHit[] targetingHit;

	private int tentacleLayer;

	private int ignoreAllLayer;

	private Vector3 searchAreaPosition;

	private Vector3 searchAreaForward;

	private bool gameStarted;

	private float InterestTimer;

	private GameObject grabbedObject;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void GameStarted()
	{
	}

	private void Update()
	{
	}

	private void UpdateTentacle()
	{
	}

	private void Idle()
	{
	}

	private void AttackingTarget()
	{
	}

	private void AttackingEnvironment()
	{
	}

	private void Retreating()
	{
	}

	private void Flailing()
	{
	}

	private void Shruging()
	{
	}

	private void FindTargets()
	{
	}

	public void FindNewFlailTarget()
	{
	}

	public void UpdateSegmentsFixed()
	{
	}

	public void ShrugTentacle(Vector3 ShrugDirection)
	{
	}

	public void AttackNewTarget(Rigidbody target)
	{
	}

	public void SetGrabbedObject(GameObject newGrabbedObject)
	{
	}

	public bool CanGrabObject(GameObject newGrabbedObject)
	{
		return false;
	}

	public void ReleaseTarget()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	private static void DrawLocationCross(Vector3 location, Color color, float size = 1f)
	{
	}
}
