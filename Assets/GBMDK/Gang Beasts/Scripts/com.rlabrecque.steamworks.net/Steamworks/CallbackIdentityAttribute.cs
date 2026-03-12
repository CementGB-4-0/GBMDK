using System;

namespace Steamworks
{
    [AttributeUsage(AttributeTargets.Struct, AllowMultiple = false)]
    internal class CallbackIdentityAttribute : Attribute
    {
        public CallbackIdentityAttribute(int callbackNum)
        {
        }

        public int Identity { get; set; }
    }
}