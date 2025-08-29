using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Femur;
using GB.Game.Critters;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Serialization;

public class InteractableObject : MonoBehaviour
{
	public enum Priority
	{
		Ignore = 0,
		Lowest = 1,
		Low = 2,
		Medium = 3,
		High = 4,
		Highest = 5,
		Forced = 6
	}

	public enum Damage
	{
		Ignore = 0,
		Default = 1,
		Object = 2,
		Punch = 3,
		Kick = 4,
		DivingKick = 5,
		Headbutt = 6,
		DivingHeadbutt = 7,
		Knockout = 8,
		Special_Road = 9,
		Special_Train = 10,
		DamageVolume = 11,
		Critter = 12,
		CritterAttack = 13
	}

	public enum Grab
	{
		Ignore = 0,
		Break = 1,
		DrainSlow = 2,
		DrainMedium = 3,
		DrainFast = 4,
		Perminant = 5
	}

	[CompilerGenerated]
	private sealed class _003CDelayedRegisterInteractableObjectAndChildren_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InteractableObject _003C_003E4__this;

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
		public _003CDelayedRegisterInteractableObjectAndChildren_003Ed__88(int _003C_003E1__state)
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

	[HideInInspector]
	[FormerlySerializedAs("priorityModifier")]
	public Priority legacyPriorityModifier;

	[HideInInspector]
	[FormerlySerializedAs("grabModifier")]
	public Grab legacyGrabModifier;

	[HideInInspector]
	[FormerlySerializedAs("damageModifier")]
	public Damage legacyDamageModifier;

	[HideInInspector]
	[Tooltip("Enable if the rigidbody is part of a ragdoll (This is a workaround for the extra force thats required to lift a ragdoll)")]
	[FormerlySerializedAs("partOfRagdoll")]
	public bool legacyPartOfRagdoll;

	[FormerlySerializedAs("cachedTransform")]
	[HideInInspector]
	public Transform legacyCachedTransform;

	[HideInInspector]
	[FormerlySerializedAs("cachedRigidbody")]
	public Rigidbody legacyCachedRigidbody;

	[FormerlySerializedAs("cachedColliders")]
	[HideInInspector]
	public Collider[] legacyCachedColliders;

	[FormerlySerializedAs("checkVelocity")]
	[HideInInspector]
	public bool legacyCheckVelocity;

	[HideInInspector]
	[FormerlySerializedAs("alwaysDrain")]
	public bool legacyAlwaysDrain;

	[FormerlySerializedAs("movingPlatform")]
	[HideInInspector]
	public bool legacyMovingPlatform;

	[FormerlySerializedAs("triggerBudBud")]
	[Tooltip("Enable if we want to trigger the budbud voice effect if held")]
	[HideInInspector]
	public bool legacyTriggerBudBud;

	public InteractableObjectData interactableObjectData;

	[FormerlySerializedAs("childrenInteractableObjectData")]
	[Space(20f)]
	public List<InteractableObjectData> childInteractableObjectData;

	[HideInInspector]
	public static float offset;

	public GrabEvent[] connectedGrabEvents;

	public Priority priorityModifier
	{
		get
		{
			return default(Priority);
		}
		set
		{
		}
	}

	public Grab grabModifier
	{
		get
		{
			return default(Grab);
		}
		set
		{
		}
	}

	public Damage damageModifier
	{
		get
		{
			return default(Damage);
		}
		set
		{
		}
	}

	public bool partOfRagdoll
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ignoreOnValidate
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ignoreStageHazards
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[NotNull]
	public Transform cachedTransform
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Rigidbody cachedRigidbody
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Collider[] cachedColliders
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool checkVelocity
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool alwaysDrain
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool movingPlatform
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool triggerBudBud
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isCritterTarget
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isTentacle
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Actor actor
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public BirdActor birdActor
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public RatActor ratActor
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SharkActor sharkActor
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public FishActor fishActor
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GameObject cachedGameObject
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Collider mainCollider
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void OnValidate()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayedRegisterInteractableObjectAndChildren_003Ed__88))]
	private IEnumerator DelayedRegisterInteractableObjectAndChildren()
	{
		return null;
	}

	public void CheckVelocity()
	{
	}

	public void PopulateChildrenWithCurrentValues()
	{
	}

	public void SignalOnGrab(Joint connectedJoint)
	{
	}
}
