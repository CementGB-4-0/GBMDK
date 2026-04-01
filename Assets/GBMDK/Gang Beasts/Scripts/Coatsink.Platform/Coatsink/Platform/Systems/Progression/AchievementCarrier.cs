using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Coatsink.Platform.Systems.Progression
{
    [Serializable]
    public class AchievementCarrier : ISerializable
    {
        private List<bool> _data;
        private bool _dirty;

        private List<string> _keys;

        private byte _version;

        public AchievementCarrier()
        {
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public AchievementCarrier(SerializationInfo info, StreamingContext context)
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

        public bool Get(string name)
        {
            return false;
        }

        public bool Set(string name, bool value)
        {
            return false;
        }
    }
}