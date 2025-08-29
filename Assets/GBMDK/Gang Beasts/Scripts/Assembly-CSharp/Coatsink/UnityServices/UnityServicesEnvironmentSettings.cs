using UnityEngine;

namespace Coatsink.UnityServices
{
	[CreateAssetMenu(fileName = "UnityServicesEnvironmentSettings", menuName = "ScriptableObjects/Unity Service Environment Override")]
	public class UnityServicesEnvironmentSettings : ScriptableObject
	{
		public enum ServiceEnvironmentType
		{
			production = 0,
			development = 1,
			staging = 2
		}

		[Tooltip("Use the supplied override?")]
		public bool ShouldUseOverride;

		[Tooltip("Specify a service environment to use instead of development for PIE and dev builds, production for everything else")]
		public ServiceEnvironmentType OverrideSetting;
	}
}
