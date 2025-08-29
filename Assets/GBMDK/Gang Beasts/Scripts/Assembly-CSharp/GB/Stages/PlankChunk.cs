using Audio;
using Femur;
using UnityEngine;

namespace GB.Stages
{
	public class PlankChunk : MonoBehaviour
	{
		[SerializeField]
		public Collider[] triggerCollRefs;

		[SerializeField]
		public Joint jointRef;

		[SerializeField]
		private bool FallActive;

		[SerializeField]
		private AudioClip[] onPlankFallClip;

		[SerializeField]
		private float volume;

		[Tooltip("Percentage chance to fall on trigger touch (0.0 -> 1.0)")]
		[SerializeField]
		private float breakChance;

		[SerializeField]
		private float spatialBlend;

		private bool fallen;

		private PierManager managerRef;

		private Rigidbody cachedRB;

		private AudioController.PooledAudioSource _usingSource;

		private void Start()
		{
		}

		public void Initialise(PierManager manager)
		{
		}

		public void BlockFalling()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnBeastTrigger(Actor beast)
		{
		}
	}
}
