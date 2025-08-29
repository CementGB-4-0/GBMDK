using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Audio;
using GB.Data.Loading;
using GB.Game.Data;
using GB.Networking.Utils.Spawn;
using GB.Setup;
using GB.UI.Utils;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Networking;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;

namespace GB.Core.Loading
{
	public class SceneLoader : MonoBehaviour, IAsyncResourceLoader
	{
		private class NetworkLoading : ILoadingSystem
		{
			private SceneLoader _sceneLoader;

			private SceneLoadTask _loadingLevel;

			public bool IsDone => false;

			public bool IsLoading => false;

			public bool IsWaitingActivation => false;

			public bool IsActivated => false;

			public float Progression => 0f;

			internal NetworkLoading(SceneLoader loader)
			{
			}

			public void ActivateScene()
			{
			}

			public void CompleteLoad()
			{
			}

			public void LoadScene(string map, LoadSceneMode mode)
			{
			}

			public void OnGUI()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CDownloadScenes_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SceneLoader _003C_003E4__this;

			public AssetsDownloader downloader;

			public int endLoad;

			public int startLoad;

			private ICompleteTracker _003Cresult_003E5__2;

			private int _003Cstep_003E5__3;

			private int _003Cj_003E5__4;

			private AsyncOperationHandle<SceneData> _003CsceneDataResult_003E5__5;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDownloadScenes_003Ed__46(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[SerializeField]
		private AssetReference _sceneDataRef;

		[SerializeField]
		private AssetReference _defaultSceneRef;

		private string _currentScene;

		private string _currentKey;

		private IDataCache _sceneList;

		private SceneData _defaultSceneData;

		private SceneData _sceneData;

		private NetworkLoading _networkLoader;

		private bool _isSceneListLoading;

		private bool _isDefaultSceneLoading;

		public string CurrentScene => null;

		public string CurrentKey => null;

		public AssetReference SceneRef => null;

		public SpawnList SpawnList => null;

		public SpawnPatternCarrier SpawnPattern => null;

		public WavesData WavesData => null;

		public RumbleData RumbleData => null;

		public FootballData FootballData => null;

		public CaptureTheFlagData CaptureTheFlagData => null;

		public KingOfTheHillData KingOfTheHillData => null;

		public IDataCache ModeOverrides => null;

		public SceneAudioConfig SceneAudioConfig => null;

		public SceneAudioConfig DefaultSceneAudioConfig => null;

		public static event Action OnSceneDataLoaded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		private void Awake()
		{
		}

		private void OnSceneUnloaded(Scene arg0)
		{
		}

		private void OnDestroy()
		{
		}

		public void LoadMainMenuWithLoadingScreen(bool setupMenu = true, bool disconnectNetwork = true)
		{
		}

		public SceneLoadTask LoadScene(string key, LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100)
		{
			return null;
		}

		private void OnSceneLoaded(SceneLoadTask task)
		{
		}

		[IteratorStateMachine(typeof(_003CDownloadScenes_003Ed__46))]
		public IEnumerator DownloadScenes(AssetsDownloader downloader, LoadingBar loadBar, int startLoad, int endLoad)
		{
			return null;
		}

		public void BeginAsyncLoading()
		{
		}

		public IList<object> GetAssetKeys()
		{
			return null;
		}

		private void OnSceneListComplete(AsyncOperationStatus result, AssetReference assetRef, object data)
		{
		}

		private void OnDefaultSceneComplete(AsyncOperationStatus result, AssetReference assetRef, object data)
		{
		}

		public bool HasFinishedAsyncLoading()
		{
			return false;
		}

		public bool HasErrors()
		{
			return false;
		}
	}
}
