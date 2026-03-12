using System;
using System.Collections.Generic;
using System.Reflection;

namespace PartyCSharpSDK
{
    public class ObjectPool
    {
        private static object[] ctorParamList0Element;

        private static object[] ctorParamList1Element;

        private static object[] ctorParamList2Element;

        private Dictionary<Type, Pool> pools;

        static ObjectPool()
        {
        }

        public void AddEntry<T>(int maxLimit, Type[] ctorTypes)
        {
        }

        public T Retrieve<T>()
        {
            return default(T);
        }

        public T Retrieve<T>(object param)
        {
            return default(T);
        }

        public T Retrieve<T>(object param0, object param1)
        {
            return default(T);
        }

        public T Retrieve<T>(object[] ctorParams)
        {
            return default(T);
        }

        public void Return(object o)
        {
        }

        internal class Pool
        {
            internal ConstructorInfo ctor;
            internal int limit;

            internal List<object> objects;

            internal Pool(int limit, ConstructorInfo ctor)
            {
            }
        }
    }
}