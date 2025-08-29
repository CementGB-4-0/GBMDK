using System.Collections.Generic;
using UnityEngine;

namespace GB.UI.Menu
{
	public class MenuScreenForcer : MonoBehaviour
	{
		[SerializeField]
		private MenuController _menuController;

		[SerializeField]
		[Tooltip("Screen shown when entitlement fails")]
		private BaseMenuScreen _failedEntitlement;

		[SerializeField]
		[Tooltip("Startup splash/ loading screen")]
		private BaseMenuScreen _startupScreen;

		[SerializeField]
		[Tooltip("Screen with the main settings")]
		private BaseMenuScreen _mainScreen;

		[SerializeField]
		[Tooltip("Screen with the online menu controller on")]
		private BaseMenuScreen _lobbyScreen;

		[SerializeField]
		[Tooltip("The online menu controller")]
		private OnlineMenuController _lobbyMenu;

		[Tooltip("Screen with the wireless menu controller on")]
		[SerializeField]
		private BaseMenuScreen _wirelessLobbyScreen;

		[Tooltip("The wireless menu controller")]
		[SerializeField]
		private WirelessMenuController _wirelessLobbyMenu;

		[Tooltip("Screen for chekcing has online needs")]
		[SerializeField]
		private BaseMenuScreen _onlineChecking;

		[SerializeField]
		[Tooltip("Screen for creating an online lobby")]
		private BaseMenuScreen _onlineCreate;

		[SerializeField]
		[Tooltip("Screen for joining an online lobby")]
		private BaseMenuScreen _onlineJoining;

		[Tooltip("Screen for leaving an online lobby")]
		[SerializeField]
		private BaseMenuScreen _onlineLeaving;

		[Tooltip("Screen for demo game")]
		[SerializeField]
		private BaseMenuScreen _demo;

		[SerializeField]
		[Tooltip("Menu stack for local play returning")]
		private List<BaseMenuScreen> _localReturn;

		[Tooltip("Menu stack for demo local play returning")]
		[SerializeField]
		private List<BaseMenuScreen> _demoReturn;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private bool IsWirelessGame()
		{
			return false;
		}

		private void OnOnlineCheckStarted(int obj)
		{
		}

		private void OnLobbyCreatingEvent()
		{
		}

		private void OnLobbyJoining()
		{
		}

		private void OnJoined(int controller)
		{
		}

		private void OnLobbyLeaving()
		{
		}

		private void OnLobbyLeft()
		{
		}

		private void OnEntitlementChangedEvent(bool effect)
		{
		}

		private void Start()
		{
		}
	}
}
