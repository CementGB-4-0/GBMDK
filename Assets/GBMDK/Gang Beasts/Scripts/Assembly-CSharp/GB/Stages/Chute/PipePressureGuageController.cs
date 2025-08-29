using UnityEngine;

namespace GB.Stages.Chute
{
	public class PipePressureGuageController : MonoBehaviour
	{
		private const float PRESSURE_LIMITER = 0.6f;

		private const float MIN_RANGE = 0.05f;

		private const float MAX_RANGE = 0.2f;

		[SerializeField]
		private float rotationMin;

		[SerializeField]
		private float rotationMax;

		[SerializeField]
		[Range(0f, 1f)]
		public float movementPercentage;

		private float minPercentage;

		private float maxPercentage;

		public float Speed;

		private float increment;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void NewRange()
		{
		}

		public void SetPercentage(float percentage)
		{
		}

		private void OnValidate()
		{
		}
	}
}
