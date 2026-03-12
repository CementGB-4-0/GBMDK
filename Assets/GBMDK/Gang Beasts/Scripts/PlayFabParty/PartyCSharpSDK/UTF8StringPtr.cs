using System;

namespace PartyCSharpSDK
{
    public struct UTF8StringPtr
    {
        private IntPtr pointer;

        public UTF8StringPtr(string str, DisposableCollection disposableCollection)
        {
            pointer = (IntPtr)0;
        }

        public string GetString()
        {
            return null;
        }
    }
}