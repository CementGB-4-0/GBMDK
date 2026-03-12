using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Coatsink.Platform.Systems.Progression
{
    [Serializable]
    public class StatsCarrier : ISerializable
    {
        private List<DataCarrier> _data;

        private bool _dirty;

        private List<string> _keys;

        private byte _version;

        public StatsCarrier()
        {
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public StatsCarrier(SerializationInfo info, StreamingContext context)
        {
        }

        public bool Dirty
        {
            get { return false; }
            set { }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
        }

        [Serializable]
        [StructLayout((LayoutKind)2)]
        private struct DataCarrier
        {
            [FieldOffset(0)] public int Int;

            [FieldOffset(0)] public float Float;
        }
    }
}