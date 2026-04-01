using UnityEngine;

namespace CS.CorePlatform.None.Client.Part
{
    public class NoneUtils : MonoBehaviour
    {
        private bool _guiActive;
        private NonePlatformManager _manager;

        public bool GUIActive
        {
            get { return false; }
            set { }
        }

        private void Awake()
        {
        }

        private void PlatformSystemMessenger_OnMessageChange(bool obj)
        {
        }
    }
}