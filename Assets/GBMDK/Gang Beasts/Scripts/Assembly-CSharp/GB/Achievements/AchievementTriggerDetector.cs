using System.Collections.Generic;
using Femur;
using UnityEngine;

namespace GB.Achievements
{
	public class AchievementTriggerDetector : AchievementManager
	{
		[Tooltip("The JSON-friendly name for this achievement")]
		[SerializeField]
		private string RelatedAchievementName;

		[SerializeField]
		private AchievementTrigger[] TriggerRequirements;

		[Tooltip("Whether the order the triggers are activated in matters towards achievement progress")]
		[SerializeField]
		private bool OrderImportant;

		[SerializeField]
		[Tooltip("How many of the assigned elements must trigger for this achievement to be unlocked. \r\nFor most 'OrderImportant' triggers, this should be equal to the number of elements.")]
		private int ElementTriggerReqNum;

		[SerializeField]
		private List<PostCondition> PostTriggerConditions;

		private int receivedPositiveConditions;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public bool OnFinalConditionComplete(Actor beastRef = null)
		{
			return false;
		}

		public bool CheckAllowedTrigger(AchievementTrigger trigger, Actor beastRef = null)
		{
			return false;
		}

		private void OnCompositeComplete(Actor unlockingBeast = null)
		{
		}

		public void ReceivePostConditionStatus(bool status, Actor beastRef)
		{
		}

		public override void AddPostCondition(PostCondition cond)
		{
		}

		public override void CheckAllConditionsComplete(AchievementCondition lastTrigger, Actor triggeringBeast)
		{
		}
	}
}
