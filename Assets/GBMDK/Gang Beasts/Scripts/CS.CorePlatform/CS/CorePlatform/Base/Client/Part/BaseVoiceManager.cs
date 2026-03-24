using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace CS.CorePlatform.Base.Client.Part
{
    public class BaseVoiceManager : MonoBehaviour
    {
        protected static object _lockBody;

        protected static object _lockThread;

        protected List<VoiceConnection> _connectedUsers;

        private bool _defaultMute;

        private float _defaultVolume;
        protected BasePlatformManager _Manager;

        protected byte[] _messageBuffer;

        protected bool _RunningThread;

        protected bool _RunThread;

        private bool _voiceRunning;

        protected Thread _voiceThread;

        private bool _voipEnabled;

        public bool VoiceRunning
        {
            get { return false; }
            set { }
        }

        public int TotalConnectedUsers => 0;

        public float DefaultVolume
        {
            get { return 0f; }
            set { }
        }

        public bool DefaultMute
        {
            get { return false; }
            set { }
        }

        public bool VoipEnabled
        {
            get { return false; }
            set { }
        }

        protected bool RunningThread => false;

        private void Awake()
        {
        }

        public virtual void StartVoice()
        {
        }

        public virtual void StopVoice()
        {
        }

        public virtual void VoiceDataMessage(ulong userID, byte[] message, int size)
        {
        }

        public virtual uint PrepNewVoiceData(ref byte[] message, int size)
        {
            return 0u;
        }

        public void VoiceEndMessage(ulong userID, byte[] message, int size)
        {
        }

        public void ConnectionAdd(ulong userID)
        {
        }

        public virtual void SetUpVoice(ref VoiceConnection newVoice)
        {
        }

        public void ConnectionRemove(ulong userID, bool tellThem = true)
        {
        }

        public virtual void TellRemoving(int index)
        {
        }

        public void ConnectionMute(ulong userID, bool setMute)
        {
        }

        public bool ConnectionMuted(ulong userID)
        {
            return false;
        }

        public void SetVoiceMutes(bool setMute)
        {
        }

        public void ConnectionsEnd()
        {
        }

        public AudioClip GetAudioClips(ulong userID)
        {
            return null;
        }

        public AudioClip GetAudioClips(int index)
        {
            return null;
        }

        public void SetVoiceVolume(ulong userID, float volume)
        {
        }

        public void SetVoiceVolume(int index, float volume)
        {
        }

        public void SetVoiceVolumes(float volume)
        {
        }

        public float GetVoiceVolume(ulong userID)
        {
            return 0f;
        }

        public float GetVoiceVolume(int index)
        {
            return 0f;
        }

        public virtual void StartVoiceThread()
        {
        }

        public virtual void StopVoiceThread()
        {
        }

        public virtual void WaitForVoiceThreadEnd()
        {
        }

        protected void VoiceThread()
        {
        }

        public virtual void RecordAndSendVoice()
        {
        }
    }
}