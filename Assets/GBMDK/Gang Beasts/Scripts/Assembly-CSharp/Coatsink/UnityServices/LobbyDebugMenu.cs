using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Coatsink.UnityServices
{
	public class LobbyDebugMenu : MonoBehaviour
	{
		[SerializeField]
		private GameObject _menuPanel;

		[SerializeField]
		private TMP_InputField _roomCodeField;

		[SerializeField]
		private Button _joinLobbyButton;

		[SerializeField]
		private Toggle _crossplayToggle;

		[SerializeField]
		private InputActionReference _colourUpAction;

		[SerializeField]
		private InputActionReference _colourDownAction;

		[SerializeField]
		private InputActionReference _showPlayerNameAction;

		private bool _isVisible;

		public void ToggleMenu()
		{
		}

		public void SetJoinCode(string value)
		{
		}

		public void SetIsJoinButtonInteractable(bool visible)
		{
		}

		public void SetIsCrossplayToggleInteractable(bool visible)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnShowPlayerNameAction(InputAction.CallbackContext context)
		{
		}

		private void OnLobbyJoined()
		{
		}

		private void OnLobbyLeft()
		{
		}

		public void OnJoinButtonPressed()
		{
		}

		private void JoinLobbyViaCodeInternal()
		{
		}

		public void OnCrossplayToggled(bool value)
		{
		}
	}
}
