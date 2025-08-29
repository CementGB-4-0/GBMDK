using CoreNet.Pooling;
using UnityEngine;

namespace GB.Stages.Train
{
	public class TrackMover : PooledLocalItem
	{
		[HideInInspector]
		public float movementSpeed;

		[HideInInspector]
		public Vector3 endPoint;

		private Rigidbody thisRigidbody;

		[Header("Spawn Logic")]
		public Vector3 trackSectionOffset;

		[SerializeField]
		private TrackPool.Direction[] _spawnOptions;

		[SerializeField]
		[Header("Random Logic")]
		private GameObject[] _props;

		[SerializeField]
		private byte _maxProps;

		private byte _syncTag;

		[SerializeField]
		private TrackNode[] _connections;

		private bool _gameStarted;

		public Rigidbody CachedRigidbody => null;

		public byte SyncTag
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public TrackNode LastConnection => null;

		public TrackNode FirstConnection => null;

		public bool GameStarted
		{
			set
			{
			}
		}

		public void ConnectTracks(TrackMover next)
		{
		}

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		public TrackPool.Direction GetNextSpawnDirection()
		{
			return default(TrackPool.Direction);
		}

		public TrackPool.Direction GetNextSpawnDirection(TrackPool.Direction not)
		{
			return default(TrackPool.Direction);
		}

		public override void OnSpawn()
		{
		}

		public int RandomizeProps()
		{
			return 0;
		}

		public void SetProps(int index)
		{
		}
	}
}
