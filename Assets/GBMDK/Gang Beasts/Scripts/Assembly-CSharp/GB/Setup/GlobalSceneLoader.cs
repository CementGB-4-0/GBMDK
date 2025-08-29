using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GB.Config;
using GB.Core.Bootstrappers;
using GB.Core.Loading;
using GB.Data.Loading;
using GB.UI.Utils;
using GB.View.UI;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

namespace GB.Setup
{
	public class GlobalSceneLoader : MonoBehaviour
	{
		[Serializable]
		private struct LogoSplash
		{
			public float fadeInTime;

			public Texture2D logoImage;

			public float showTime;

			public float fadeOutTime;

			public float fadeScale;

			public LogoSplash(Texture2D _logo, float _fadeIn, float _fadeOut, float _show, float _fadeScale)
			{
				fadeInTime = 0f;
				logoImage = null;
				showTime = 0f;
				fadeOutTime = 0f;
				fadeScale = 0f;
			}
		}

		public delegate bool ScreenWaitingCheckDelegate();

		[CompilerGenerated]
		private sealed class _003CLoadGlobal_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GlobalSceneLoader _003C_003E4__this;

			private AsyncOperationHandle<GameObject> _003CglobalCreator_003E5__2;

			private int _003Ci_003E5__3;

			private IDeferredActivator _003Cactivator_003E5__4;

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
			public _003CLoadGlobal_003Ed__44(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CLoadAsyncResources_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GlobalSceneLoader _003C_003E4__this;

			private int _003Ci_003E5__2;

			private IPostAsyncLoadingActivator _003Cactivator_003E5__3;

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
			public _003CLoadAsyncResources_003Ed__45(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CLoadMenu_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GlobalSceneLoader _003C_003E4__this;

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
			public _003CLoadMenu_003Ed__46(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CFadeLoading_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GlobalSceneLoader _003C_003E4__this;

			private float _003Ctime_003E5__2;

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
			public _003CFadeLoading_003Ed__47(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CDisplaySplashScreen_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GlobalSceneLoader _003C_003E4__this;

			public int splash;

			public ScreenWaitingCheckDelegate isWaitingCheck;

			private float _003Ctime_003E5__2;

			private float _003CchangeSize_003E5__3;

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
			public _003CDisplaySplashScreen_003Ed__49(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CStart_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GlobalSceneLoader _003C_003E4__this;

			private int _003Ci_003E5__2;

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
			public _003CStart_003Ed__52(int _003C_003E1__state)
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

		public static GlobalSceneLoader Instance;

		public static readonly string BOOT_LOAD_SCENE;

		public static readonly bool LocalAssets;

		[SerializeField]
		private AssetReference _globalAssetRef;

		[SerializeField]
		private GBConfigData _config;

		[SerializeField]
		private List<ResourceCache> _resourceList;

		[SerializeField]
		private ResourceCache _debugResources;

		[SerializeField]
		private List<ResourceObject> _resourceItemsList;

		[SerializeField]
		private List<LogoSplash> _logos;

		[SerializeField]
		private RawImage _logoImage;

		[SerializeField]
		private float _loadFadeTime;

		[SerializeField]
		private GameObject _loadingScreen;

		[SerializeField]
		private CanvasGroup _loadCanvas;

		[SerializeField]
		private UIController _loadingUI;

		[SerializeField]
		private GameObject _bootCameraHelper;

		[SerializeField]
		private LoadingBar _loadBar;

		private AsyncOperation globalLoader;

		private SceneLoadTask menuLoader;

		private bool _skipping;

		private bool _startResourcesLoaded;

		private NetworkBootstrapper _networkSetup;

		private List<IDeferredActivator> m_DefferedActivators;

		private List<IAsyncResourceLoader> m_AsyncResourceLoaders;

		private List<IPostAsyncLoadingActivator> m_PostAsyncLoadingActivators;

		private AssetsDownloader _downloader;

		private bool _needsToReload;

		public static bool FastLoadMode => false;

		public bool StartResourcesLoaded => false;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		private void RegisterDeferredActivatorInternal(IDeferredActivator activator)
		{
		}

		private void RegisterAsyncResourceLoaderInternal(IAsyncResourceLoader loader)
		{
		}

		private void RegisterPostAsyncLoadingActivatorInternal(IPostAsyncLoadingActivator activator)
		{
		}

		private void UnregisterDeferredActivatorInternal(IDeferredActivator activator)
		{
		}

		private void UnregisterAsyncResourceLoaderInternal(IAsyncResourceLoader loader)
		{
		}

		private void UnregisterPostAsyncLoadingActivatorInternal(IPostAsyncLoadingActivator activator)
		{
		}

		public static void RegisterDeferredActivator(IDeferredActivator activator)
		{
		}

		public static void RegisterAsyncResourceLoader(IAsyncResourceLoader loader)
		{
		}

		public static void RegisterPostAsyncLoadingActivator(IPostAsyncLoadingActivator activator)
		{
		}

		public static void UnregisterDeferredActivator(IDeferredActivator activator)
		{
		}

		public static void UnregisterAsyncResourceLoader(IAsyncResourceLoader loader)
		{
		}

		public static void UnregisterPostAsyncLoadingActivator(IPostAsyncLoadingActivator activator)
		{
		}

		[IteratorStateMachine(typeof(_003CLoadGlobal_003Ed__44))]
		private IEnumerator LoadGlobal()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLoadAsyncResources_003Ed__45))]
		private IEnumerator LoadAsyncResources()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLoadMenu_003Ed__46))]
		private IEnumerator LoadMenu()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CFadeLoading_003Ed__47))]
		private IEnumerator FadeLoading()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDisplaySplashScreen_003Ed__49))]
		private IEnumerator DisplaySplashScreen(int splash, ScreenWaitingCheckDelegate isWaitingCheck)
		{
			return null;
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		[IteratorStateMachine(typeof(_003CStart_003Ed__52))]
		private IEnumerator Start()
		{
			return null;
		}

		private bool IsBlocked()
		{
			return false;
		}

		private bool IsWaitingOnAsyncResourceLoading()
		{
			return false;
		}

		private bool AnyButtonCheck()
		{
			return false;
		}
	}
}
