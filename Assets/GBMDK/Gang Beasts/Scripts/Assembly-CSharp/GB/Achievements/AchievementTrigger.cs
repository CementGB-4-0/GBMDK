using System;
using Femur;
using UnityEngine;

namespace GB.Achievements
{
	[Serializable]
	public class AchievementTrigger
	{
		[SerializeField]
		[Tooltip("The trigger condition of this trigger - NOTE: HOLD TRIGGERS NOT SUPPORTED FOR ACHIEVEMENTS YET")]
		private AchievementTriggerType TriggerType;

		[SerializeField]
		[Tooltip("The trigger collider to listen to")]
		private Collider TriggerCollider;

		[SerializeField]
		[Tooltip("collection of trigger colliders to listen to, if this is not 0 'TriggerCollider' will not be used")]
		private Collider[] TriggerColliders;

		[SerializeField]
		[Tooltip("Unique game object to listen for collisions on. Ignored if trigger type does not require a unique object.")]
		private GameObject TriggerListenObj;

		[Tooltip("Particular beast body part to listen on. Ignored if the trigger type does not require a particular body part")]
		[SerializeField]
		private BodyEnum[] ActorListenPart;

		[Tooltip("The period of time it takes this trigger to 'unset' itself. A value of -1 means the trigger will never unset.")]
		[SerializeField]
		private float TriggerCancelTime;

		[SerializeField]
		[Tooltip("Whether the beast in question must be alive to trigger this achievement")]
		private bool AliveBeastsOnly;

		private bool _isLastTrigger;

		private AchievementTriggerDetector _parentTrig;

		private TriggerBeastTracker[] beastTrackers;

		private float _lastTriggerTime;

		private void OnDestroy()
		{
		}

		public void Init(AchievementTriggerDetector handler, bool isLast = false)
		{
		}

		private void OnNetRoundOrganiserStarted()
		{
		}

		private void SetupBeastTracking()
		{
		}

		public void Update()
		{
		}

		public bool IsActive()
		{
			return false;
		}

		public bool IsActive(Actor beastRef)
		{
			return false;
		}

		private void OnTriggered()
		{
		}

		private void OnTriggered(Actor beastRef)
		{
		}

		public void AlertBeastFailed(Actor beast)
		{
		}
	}
}
