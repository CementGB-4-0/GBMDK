using UnityEngine;

namespace Coatsink.Common
{
	public class Serializer_Prefab : MonoBehaviour
	{
		[ReadOnly]
		[SerializeField]
		private string _resourcePath;

		public string resourcePath => null;

		protected virtual bool requiresResourceFolder => false;
	}
}
