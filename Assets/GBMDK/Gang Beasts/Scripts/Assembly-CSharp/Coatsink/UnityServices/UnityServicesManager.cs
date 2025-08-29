using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Coatsink.Platform.Systems.User;
using Coatsink.UnityServices.Authentication;
using Coatsink.UnityServices.Matchmaking;
using Coatsink.UnityServices.QoS;
using Unity.Services.Core;
using UnityEngine;

namespace Coatsink.UnityServices
{
	public class UnityServicesManager : MonoBehaviour
	{
		[Flags]
		public enum InitialiseFlags
		{
			None = 1,
			GameClient = 2,
			DedicatedServer = 4
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitialiseUnityServicesAsync_003Ed__46 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public UnityServicesManager _003C_003E4__this;

			public string profileName;

			private InitializationOptions _003CserviceOptions_003E5__2;

			private int _003CloopsRemaining_003E5__3;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<AuthState> _003C_003Eu__2;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitialiseMatchmakerClientAsync_003Ed__47 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public UnityServicesManager _003C_003E4__this;

			public string profileName;

			public InitialiseFlags initialiseFlags;

			public string multiplayFleetId;

			public Action InitialisedCallback;

			private TaskAwaiter<bool> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitialiseMultiplayServerAsync_003Ed__48 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public UnityServicesManager _003C_003E4__this;

			public string profileName;

			public InitialiseFlags initialiseFlags;

			public Action InitialisedCallback;

			private TaskAwaiter<bool> _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		public const string SERVICE_ENVIRONMENT = "production";

		public const string ENVIRONMENT_KEY = "com.unity.services.core.environment-name";

		[SerializeField]
		private GameObject LobbyDebugMenuPrefab;

		[SerializeField]
		private bool CrossplayEnabledByDefault;

		[SerializeField]
		private string CrossplayEnabledKey;

		private bool crossplayPlayerEnabled;

		private bool crossplayRemoteEnabled;

		private static UnityServicesManager instance;

		private MultiplayQoSWrapper qosWrapper;

		private MatchmakingManager matchmakingManager;

		private MultiplayAllocationService allocationService;

		private MultiplayServerQueryService serverQueryService;

		[SerializeField]
		private UnityServicesEnvironmentSettings environmentSettings;

		private bool initialConfigFetch;

		public bool IsCrossplayEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ServicesInitialised { get; private set; }

		public bool MatchmakingInitialised { get; private set; }

		public string ProfileName { get; private set; }

		public string PlayerId { get; private set; }

		public static UnityServicesManager Instance => null;

		public MatchmakingManager MatchmakingManager => null;

		public MultiplayQoSWrapper QosWrapper => null;

		public MultiplayServerQueryService ServerQueryService => null;

		public MultiplayAllocationService AllocationManager => null;

		public void InitialiseMatchmakerClient(InitialiseFlags initialiseFlags, Action InitialisedCallback, string multiplayFleetId, string profileName)
		{
		}

		public void InitialiseMultiplayServer(InitialiseFlags initialiseFlags, Action InitialisedCallback, string profileName)
		{
		}

		[AsyncStateMachine(typeof(_003CInitialiseUnityServicesAsync_003Ed__46))]
		private Task<bool> InitialiseUnityServicesAsync(string profileName)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CInitialiseMatchmakerClientAsync_003Ed__47))]
		private void InitialiseMatchmakerClientAsync(InitialiseFlags initialiseFlags, Action InitialisedCallback, string multiplayFleetId, string profileName)
		{
		}

		[AsyncStateMachine(typeof(_003CInitialiseMultiplayServerAsync_003Ed__48))]
		private void InitialiseMultiplayServerAsync(InitialiseFlags initialiseFlags, Action InitialisedCallback, string profileName)
		{
		}

		private void Start()
		{
		}

		private void OnPrimaryUserSignedIn(LocalID mainLocalId)
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		public bool GetPlayerCrossplaySetting()
		{
			return false;
		}

		public void SetPlayerCrossplaySetting(bool value)
		{
		}

		public void SavePlayerCrossplaySetting()
		{
		}

		public void LoadPlayerCrossplaySetting()
		{
		}

		public void ResetCrossplaySetting()
		{
		}
	}
}
