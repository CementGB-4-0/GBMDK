using System;
using CoreNet.Utils;
using GB.Utils;
using UnityEngine;
using UnityEngine.Events;

namespace GB.Networking.Utils.Spawn
{
	public class GBSpawnPoint : CoreNetSpawnPosition, ISerializationCallbackReceiver
	{
		[Flags]
		public enum SpawnPointTypes
		{
			Player = 1,
			AI = 2,
			StartPoint = 4,
			RespawnPoint = 8,
			FootballPoint = 0x10,
			CTFFlag = 0x20,
			HillPoint = 0x40
		}

		[SerializeField]
		[EnumUtils.EnumFlags]
		[Tooltip("Spawn Point Type")]
		private SpawnPointTypes _spawnPointType;

		[SerializeField]
		[Tooltip("Spawn point will only spawn for the team that is assigned to this group index (-1 = any | -2 = unassigned | -3 = don't care)")]
		private int _groupIndex;

		[SerializeField]
		[Tooltip("Spawn point will only spawn for the team that is assigned index (-1 = any | -2 = unassigned | -3 = don't care)")]
		private int _teamIndex;

		[Tooltip("Weight of use over other points")]
		[SerializeField]
		private int _ID;

		[SerializeField]
		private UnityEvent<int> OnGangSet;

		public SpawnPointTypes SpawnPointType => default(SpawnPointTypes);

		public virtual int GroupIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual int TeamIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual int Size => 0;

		public virtual int Used => 0;

		public virtual int ID => 0;

		public virtual bool Free => false;

		public virtual void Use(SpawnParams param)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
