using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace PlayFab.Json
{
    [GeneratedCode("simple-json", "1.0.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class JsonObject : IDictionary<string, object>, ICollection<KeyValuePair<string, object>>,
        IEnumerable<KeyValuePair<string, object>>, IEnumerable
    {
        private const int DICTIONARY_DEFAULT_SIZE = 16;

        private readonly Dictionary<string, object> _members;

        public JsonObject()
        {
        }

        public JsonObject(IEqualityComparer<string> comparer)
        {
        }

        public object this[int index] => null;

        public ICollection<string> Keys => null;

        public ICollection<object> Values => null;

        public object this[string key]
        {
            get { return null; }
            set { }
        }

        public int Count => 0;

        public bool IsReadOnly => false;

        public void Add(string key, object value)
        {
        }

        public bool ContainsKey(string key)
        {
            return false;
        }

        public bool Remove(string key)
        {
            return false;
        }

        public bool TryGetValue(string key, out object value)
        {
            value = null;
            return false;
        }

        public void Add(KeyValuePair<string, object> item)
        {
        }

        public void Clear()
        {
        }

        public bool Contains(KeyValuePair<string, object> item)
        {
            return false;
        }

        public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
        {
        }

        public bool Remove(KeyValuePair<string, object> item)
        {
            return false;
        }

        public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
        {
            return null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return null;
        }

        internal static object GetAtIndex(IDictionary<string, object> obj, int index)
        {
            return null;
        }

        public override string ToString()
        {
            return null;
        }
    }
}