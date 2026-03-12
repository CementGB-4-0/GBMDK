using Coatsink.Platform.Systems.User;

namespace CS.CorePlatform.Utils.Data
{
    public class PlatformMessageBase : PlatformDataWrapper
    {
        private OnlineID _fallbackID;

        public MessageTypes MessageType
        {
            get { return default(MessageTypes); }
            set { }
        }

        public OnlineID FallbackID
        {
            set { }
        }

        protected override void Serialize(DataWriter writer)
        {
        }

        protected override void Deserialize(DataReader reader)
        {
        }

        public static void SetToAfterFallbackID(DataReader message)
        {
        }

        public static OnlineID ReadFallbackID(byte[] message)
        {
            return default(OnlineID);
        }
    }
}