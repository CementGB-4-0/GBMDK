using System.Collections.Generic;
using Femur;
using UnityEngine;

namespace GB.Achievements
{
	public class AchievementBreakDetector : AchievementManager
	{
		[SerializeField]
		private string RelatedAchievementName;

		[Tooltip("Break groups referenced by this achievement")]
		[SerializeField]
		private CompositeBreak[] ReferencedBreakDetectGroups;

		[Tooltip("Number of referenced break groups that must be satisfied for the achievement to trigger")]
		[SerializeField]
		private int GroupCompletionsRequired;

		[SerializeField]
		private List<PostCondition> PostBreakConditions;

		private int receivedPositiveConditions;

		private int _numGroupCompleted;

		private bool _groupCompleted;

		public void Start()
		{
		}

		public void AlertGroupCompleted(CompositeBreak composite, Actor breakingBeast)
		{
		}

		public void OnCompositeComplete(Actor beast)
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
