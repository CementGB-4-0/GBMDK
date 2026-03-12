using System;
using System.Collections;
using System.Collections.Specialized;

namespace LitJson
{
    public class JsonMockWrapper : IJsonWrapper, IList, IOrderedDictionary, ICollection, IEnumerable, IDictionary
    {
        bool IList.IsFixedSize => false;

        bool IList.IsReadOnly => false;

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public object this[int index]
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        object IList.this[int index]
        {
            get { return null; }
            set { }
        }

        int ICollection.Count => 0;

        bool ICollection.IsSynchronized => false;

        object ICollection.SyncRoot => null;

        bool IDictionary.IsFixedSize => false;

        bool IDictionary.IsReadOnly => false;

        ICollection IDictionary.Keys => null;

        ICollection IDictionary.Values => null;

        object IDictionary.this[object key]
        {
            get { return null; }
            set { }
        }

        public bool IsArray => false;

        public bool IsBoolean => false;

        public bool IsDouble => false;

        public bool IsInt => false;

        public bool IsLong => false;

        public bool IsObject => false;

        public bool IsString => false;

        public bool GetBoolean()
        {
            return false;
        }

        public double GetDouble()
        {
            return 0.0;
        }

        public int GetInt()
        {
            return 0;
        }

        public long GetLong()
        {
            return 0L;
        }

        public string GetString()
        {
            return null;
        }

        public void SetBoolean(bool val)
        {
        }

        public void SetDouble(double val)
        {
        }

        public void SetInt(int val)
        {
        }

        public void SetJsonType(JsonType type)
        {
        }

        public void SetLong(long val)
        {
        }

        public void SetString(string val)
        {
        }

        public string ToJson()
        {
            return null;
        }

        public void ToJson(JsonWriter writer)
        {
        }

        int IList.Add(object value)
        {
            return 0;
        }

        void IList.Clear()
        {
        }

        bool IList.Contains(object value)
        {
            return false;
        }

        int IList.IndexOf(object value)
        {
            return 0;
        }

        void IList.Insert(int i, object v)
        {
        }

        void IList.Remove(object value)
        {
        }

        public void Insert(int index, object key, object value)
        {
            throw new NotImplementedException();
        }

        void IList.RemoveAt(int index)
        {
        }

        void ICollection.CopyTo(Array array, int index)
        {
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return null;
        }

        void IDictionary.Add(object k, object v)
        {
        }

        void IDictionary.Clear()
        {
        }

        bool IDictionary.Contains(object key)
        {
            return false;
        }

        void IDictionary.Remove(object key)
        {
        }

        IDictionaryEnumerator IDictionary.GetEnumerator()
        {
            return null;
        }

        IDictionaryEnumerator IOrderedDictionary.GetEnumerator()
        {
            return null;
        }
    }
}