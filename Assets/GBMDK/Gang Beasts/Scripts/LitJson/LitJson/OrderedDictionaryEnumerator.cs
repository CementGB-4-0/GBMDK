using System.Collections;
using System.Collections.Generic;

namespace LitJson
{
    internal class OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator
    {
        private IEnumerator<KeyValuePair<string, JsonData>> list_enumerator;

        public OrderedDictionaryEnumerator(IEnumerator<KeyValuePair<string, JsonData>> enumerator)
        {
        }

        public object Current => null;

        public DictionaryEntry Entry => default(DictionaryEntry);

        public object Key => null;

        public object Value => null;

        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {
        }
    }
}