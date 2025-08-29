using System.Collections.Generic;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace GB.UI
{
	public class MenuHandlerMaps : Selectable, ISubmitHandler, IEventSystemHandler, IPointerClickHandler
	{
		private List<string> mapList;

		public TextMeshProUGUI mapValueText;

		public bool AllowChange;

		private int currentMapIndex;

		public int MapIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected override void Start()
		{
		}

		public void UpdateMapList(List<string> maps)
		{
		}

		public override void OnMove(AxisEventData eventData)
		{
		}

		public void ChangeValue(int value)
		{
		}

		public List<string> GetCurrentSelectedLevels(out bool random)
		{
			random = default(bool);
			return null;
		}

		private void UpdateText()
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
