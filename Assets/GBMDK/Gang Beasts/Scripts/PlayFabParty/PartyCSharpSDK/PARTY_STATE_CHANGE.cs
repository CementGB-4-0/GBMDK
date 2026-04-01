using System;

namespace PartyCSharpSDK
{
    public class PARTY_STATE_CHANGE
    {
        protected bool useObjectPool;

        protected PARTY_STATE_CHANGE(PARTY_STATE_CHANGE_TYPE StateChangeType, IntPtr StateChangeId)
        {
        }

        public PARTY_STATE_CHANGE_TYPE StateChangeType { get; }

        internal IntPtr StateChangeId { get; }

        internal static PARTY_STATE_CHANGE CreateFromPtr(IntPtr stateChangePtr)
        {
            return null;
        }

        internal virtual void Cleanup()
        {
        }
    }
}