using System.Collections.Generic;
using GB.Gamemodes;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

namespace GB.UI
{
	public class MenuHandlerWins : Selectable, ISubmitHandler, IEventSystemHandler, IPointerClickHandler
	{
		private int[] allowedValues;

		public TextMeshProUGUI titleText;

		public TextMeshProUGUI valueText;

		public LocalizeStringEvent titleString;

		public LocalizeStringEvent valueString;

		public bool AllowChange;

		private Dictionary<GameModeEnum, int> perModeIndices;

		private GameModeEnum currentMode;

		private int backupIndex;

		public int CurrentValue => 0;

		public int CurrentIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private bool ValuesExist => false;

		protected override void Start()
		{
		}

		public void SetGameMode(GameModeEnum newMode)
		{
		}

		public void UpdateAllowedValues(int min, int max)
		{
		}

		public void UpdateAllowedValues(int[] allowedVals)
		{
		}

		public override void OnMove(AxisEventData eventData)
		{
		}

		public void ChangeValue(int value)
		{
		}

		public void OnSubmit(BaseEventData eventData)
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		public void UpdateTitle_Loadstring(string text)
		{
		}

		public void UpdateTitle(LocalizedString title)
		{
		}

		private void UpdateText()
		{
		}

		public override void OnPointerEnter(PointerEventData eventData)
		{
		}
	}
}
