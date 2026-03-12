using System;
using CS.CorePlatform.Base.Client.Part;
using CS.CorePlatform.None.Client.Part;
using CS.CorePlatform.Utils;
using UnityEngine;

namespace CS.CorePlatform.None.Client
{
    public class NonePlatformManager : BasePlatformManager
    {
        private PlatformSystemMessenger _dialogUI;
        private SystemSaveLoad _storage;

        private NoneUtils _utils;

        public SystemSaveLoad Storage => null;

        public PlatformSystemMessenger Dialog => null;

        public NoneUtils Utils => null;

        public override bool StorageDisabled
        {
            get { return false; }
            set { }
        }

        public override bool IsLocalSaving => false;

        public override bool IsLocalLoading => false;

        public override bool GUIActive => false;

        public override int MaxLocalPlayers => 0;

        public override bool IsOnlineAllowed => false;

        public void Awake()
        {
        }

        public override PlatformKeys GetKey()
        {
            return default(PlatformKeys);
        }

        public override BaseUserInfo GetUserBaseInfo()
        {
            return default(BaseUserInfo);
        }

        public override string[] Loaded()
        {
            return null;
        }

        public override int Loaded(string file)
        {
            return 0;
        }

        public override int Load(string file, ref byte[] data, bool copy = true, bool safe = true)
        {
            return 0;
        }

        public override int Load(string file, ref string data, bool safe = true)
        {
            return 0;
        }

        public override bool Save(string file, byte[] data, int size, bool copy = false, bool safe = true)
        {
            return false;
        }

        public override bool Save(string file, string data, bool safe = true)
        {
            return false;
        }

        public override void SendSavedData()
        {
        }

        public override void LoadSavedData(string[] load)
        {
        }

        public override void ForgetFile(string file)
        {
        }

        public override bool SetToUserImage(BaseUserInfo userInfo, ref Texture2D terxtureSetting)
        {
            return false;
        }

        public override bool ShowSystemMessageYESNO(string body, Action yesAction, Action noAction,
            string yesMessage = null, string noMessage = null)
        {
            return false;
        }

        public override bool ShowSystemMessageOK(string body, Action action, string okMessage = null)
        {
            return false;
        }

        public override void UpdateOnlinePermistion(int controller = -1)
        {
        }

        public override TryOnlineResult TryToGoOnline(bool showMessage)
        {
            return default(TryOnlineResult);
        }

        public override TryOnlineResult TryToGoOnline(int controller, bool showMessage)
        {
            return default(TryOnlineResult);
        }
    }
}