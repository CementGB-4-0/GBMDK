using CS.CorePlatform;
using Coatsink.Platform.Systems.User;
using Coatsink.UnityServices.Matchmaking;
using GB.Config;
using GB.Gamemodes;
using GB.Platform.Lobby;
using GB.UI.Beasts;
using GB.UI.Lobby;
using GB.UnityServices.Matchmaking;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.Localization;
using UnityEngine.UI;

namespace GB.UI
{
	public class MenuHandlerGamemodes : Selectable, ISubmitHandler, IEventSystemHandler, IPointerClickHandler
	{
		public enum MenuType
		{
			Local = 0,
			Online = 1,
			LocalWireless = 2
		}

		private class MenuSettings
		{
			private const string LOCAL_SAVE_FILE = "Local";

			private const string ONLINE_SAVE_FILE = "Online";

			private string _saveTag;

			public GameModeEnum currentGameMode;

			public bool privateGame;

			public int currentScoreIndex;

			public int currentMapIndex;

			internal MenuSettings()
			{
			}

			internal MenuSettings(MenuType type)
			{
			}

			public void Load()
			{
			}

			public void Save(bool sendData = true)
			{
			}
		}

		private MenuSettings activeCache;

		private static MenuSettings[] settingcaches;

		public MenuType type;

		public GameObject ourContentHolder;

		public TextMeshProUGUI currentGamemodeText;

		public MenuHandlerWins winsSetup;

		public MenuHandlerMaps mapSetup;

		public Button inviteButton;

		public Button startBtn;

		private Color _startBtnDefaultDisabledColor;

		[SerializeField]
		private Selectable _beastSelector;

		private bool _privateGame;

		public GameObject loadingIcon;

		public BeastMenuManager beastMenuManager;

		public StartGameCountdown localCountdown;

		public LobbyCountdown onlineCountdown;

		[SerializeField]
		private GameModeSetupConfiguration tracker;

		[SerializeField]
		private GameModeMenuData gameModeMenuData;

		private MatchmakingTicketModel lastRequest;

		private Coroutine _connectionChecker;

		private const float PING_PULSE_TIME = 6f;

		private bool _showingOnline;

		private bool AllowChange;

		private GameModeEnum _currentGamemode;

		private RotationConfig selectedConfig;

		public bool TeamForced => false;

		public bool PrivateGame
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		public GameModeEnum CurrentGamemode
		{
			get
			{
				return default(GameModeEnum);
			}
			protected set
			{
			}
		}

		public void SetCurrentGameMode(GameModeEnum value, bool setTeamSize = true)
		{
		}

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void OnlineBeastSetupTracker_OnTeamChange(OnlinePlayerInfomationCache arg1, int arg2)
		{
		}

		private void LocalBeastSetupTracker_OnTeamChange(LocalPlayerInfomationCache arg1, int arg2)
		{
		}

		private void OnlineBeastSetupTracker_OnStateChange(OnlinePlayerInfomationCache arg1, BeastUtils.PlayerState arg2)
		{
		}

		private void LocalBeastSetupTracker_OnStateChange(LocalPlayerInfomationCache arg1, BeastUtils.PlayerState arg2)
		{
		}

		public void CheckPlayerSetup()
		{
		}

		private void SetPrivateGame(bool set)
		{
		}

		private void Update()
		{
		}

		private void UpdateOnline()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void OnAllowanceChanged(BaseUserInfo arg1, int arg2, bool arg3, OnlineID arg4)
		{
		}

		protected override void OnEnable()
		{
		}

		private void RefreshUI()
		{
		}

		private void RefreshOnlineContextButtons()
		{
		}

		private void PlatformEvents_OnMainUserStateEvent(bool effect)
		{
		}

		private void OnControllerDisconnected(in InputDevice device, int userIndex)
		{
		}

		protected override void OnDisable()
		{
		}

		public override void OnMove(AxisEventData eventData)
		{
		}

		public void ChangeValue(bool forward)
		{
		}

		public void ChangeValue(bool forward, GameModeEnum current)
		{
		}

		public void SetTeamSize()
		{
		}

		public void OnPlayerJoined(BaseUserInfo info, int id)
		{
		}

		public void OnPlayerLeft(BaseUserInfo info)
		{
		}

		public void OnUnReady()
		{
		}

		public void OnReady()
		{
		}

		private void GenerateUI()
		{
		}

		private LocalizedString GetWinSetupString(GameModeEnum type)
		{
			return null;
		}

		private void SetCachedData()
		{
		}

		private void SaveCachedData(bool sendData = true)
		{
		}

		private void PopulateVisibleButtons(bool matchmakingActive = false)
		{
		}

		public void OnCountDownStart()
		{
		}

		public void OnCountdownTerminated()
		{
		}

		public void OnCountdownComplete()
		{
		}

		private void OnMatchmakingComplete(MatchmakingResult matchmakingResult)
		{
		}

		public void OnStartGame()
		{
		}

		private void StartGameLogic()
		{
		}

		private void ValidateMatchmakingRequest(out string error)
		{
			error = null;
		}

		public void CancelMatchmaking()
		{
		}

		private void OnDisconnectUIOverride(string reason)
		{
		}

		private void SetupLoadScreen()
		{
		}

		private void SetConfigOnGameManager()
		{
		}

		private void SetupNetMemberContext()
		{
		}

		private void OnMatchmakingStateChanged(MatchmakingState matchmakingState)
		{
		}

		public override void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnSubmit(BaseEventData eventData)
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}
	}
}
