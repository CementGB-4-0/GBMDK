using System;

namespace PlayFab.Json
{
    public class SimpleJsonInstance : ISerializerPlugin, IPlayFabPlugin
    {
        public static PlayFabSimpleJsonCuztomization ApiSerializerStrategy;

        public T DeserializeObject<T>(string json)
        {
            return default(T);
        }

        public T DeserializeObject<T>(string json, object jsonSerializerStrategy)
        {
            return default(T);
        }

        public object DeserializeObject(string json)
        {
            return null;
        }

        public string SerializeObject(object json)
        {
            return null;
        }

        public string SerializeObject(object json, object jsonSerializerStrategy)
        {
            return null;
        }

        public class PlayFabSimpleJsonCuztomization : PocoJsonSerializerStrategy
        {
            public override object DeserializeObject(object value, Type type)
            {
                return null;
            }

            protected override bool TrySerializeKnownTypes(object input, out object output)
            {
                output = null;
                return false;
            }
        }
    }
}