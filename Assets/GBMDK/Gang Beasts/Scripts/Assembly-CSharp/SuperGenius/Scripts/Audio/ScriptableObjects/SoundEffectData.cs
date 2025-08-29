using System;
using UnityEngine;

namespace SuperGenius.Scripts.Audio.ScriptableObjects
{
	[Serializable]
	public class SoundEffectData
	{
		public AudioClip[] AudioClips;

		[SerializeField]
		public float Volume;

		[Tooltip("Random Between Volume +- VolumeRandomOffset")]
		[SerializeField]
		public float VolumeRandomOffset;

		[SerializeField]
		public float Pitch;

		[SerializeField]
		[Tooltip("Random Between Pitch +- PitchRandomOffset")]
		public float PitchRandomOffset;

		public float MaxDistance;

		public float RandomVolume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float RandomPitch
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public AudioClip RandomAudioClip()
		{
			return null;
		}

		public virtual void Play(Vector3 position, Transform transform)
		{
		}

		private float GetOffset(float value, float range)
		{
			return 0f;
		}
	}
}
