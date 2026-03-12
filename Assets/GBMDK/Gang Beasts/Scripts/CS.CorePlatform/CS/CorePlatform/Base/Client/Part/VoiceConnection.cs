using UnityEngine;

namespace CS.CorePlatform.Base.Client.Part
{
    public class VoiceConnection : MonoBehaviour
    {
        public enum AudioRawType
        {
            SHORT = 0,
            FLOAT = 1
        }

        public const uint VoiceBufferWriteStart = 16u;

        public const uint VoiceBufferMaxWriteChunk = 1024u;

        public AudioRawType audioRawType;

        public int voiceSampleLenght;

        public int voiceFrequancy;

        public string audioKey;

        public AudioSource voiceSource;

        public AudioClip voiceClip;

        private object _lockMute;

        private object _lockRead;

        private object _lockWrite;

        private bool _muted;

        private int _readPosition;

        private ulong _userID;

        private int _voiceBufferReadSize;

        private byte[] _voiceDataReadBuffer;

        private float[] _voiceDataReadBufferRead;

        private int _writePosition;

        public int voiceBufferReadSize
        {
            get { return 0; }
            set { }
        }

        public ulong userID
        {
            get { return 0uL; }
            set { }
        }

        private int ReadPosition
        {
            get { return 0; }
            set { }
        }

        private int WritePosition
        {
            get { return 0; }
            set { }
        }

        public bool Muted
        {
            get { return false; }
            set { }
        }

        public void DestroySource()
        {
        }

        public void SetMuted(bool value)
        {
        }

        public void SetNewVoice(byte[] voiceData, uint newDataSize)
        {
        }

        private void OnReaderCallback(float[] data)
        {
        }

        public void ConvertShort(ref float data)
        {
        }

        public void ConvertFloat(ref float data)
        {
        }
    }
}