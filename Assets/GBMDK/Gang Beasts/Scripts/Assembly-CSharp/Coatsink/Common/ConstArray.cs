using System;
using UnityEngine;

namespace Coatsink.Common
{
	[Serializable]
	public class ConstArray<T>
	{
		public T[] _data;

		[ReadOnly]
		[SerializeField]
		private uint _dataNum;

		public T this[uint key]
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public T this[int key]
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public uint Length => 0u;

		public int sLength => 0;

		public int MaxSize => 0;

		public ConstArray(uint size)
		{
		}

		protected ConstArray()
		{
		}

		public void Add(T obj)
		{
		}

		public void Insert(T obj, uint index)
		{
		}

		public void Remove(T objectT)
		{
		}

		public void RemoveAtIndex(uint index)
		{
		}

		public bool Contains(T objectT)
		{
			return false;
		}

		public void RemoveStable(T objectT)
		{
		}

		public void Clear()
		{
		}

		public T[] ToArray()
		{
			return null;
		}
	}
}
