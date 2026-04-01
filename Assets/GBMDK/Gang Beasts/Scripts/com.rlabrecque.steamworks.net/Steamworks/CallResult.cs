using System;

namespace Steamworks
{
    public abstract class CallResult
    {
        internal abstract void OnRunCallResult(IntPtr pvParam, bool bFailed, ulong hSteamAPICall);

        internal abstract void SetUnregistered();
    }
}