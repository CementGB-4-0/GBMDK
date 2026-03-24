using System;

namespace PartyCSharpSDK
{
    public static class MarshalHelpers
    {
        public delegate uint GetContextFunc<InteropHandle>(InteropHandle handle, out IntPtr context);

        public delegate uint GetHandlesFun<InputInteropHandle>(InputInteropHandle input, out uint count,
            out IntPtr handles);

        public static uint GetCustomContext<InteropHandle>(GetContextFunc<InteropHandle> getContextFunc,
            InteropHandle handle, out object customContext)
        {
            customContext = null;
            return 0u;
        }

        public static uint SetCustomContext<InteropHandle>(GetContextFunc<InteropHandle> getContextFunc,
            Func<InteropHandle, IntPtr, uint> setContextFunc, InteropHandle handle, object customContext)
        {
            return 0u;
        }

        public static uint GetArrayOfObjects<InputInteropHandle, IntermediaObject, OutputObject>(
            GetHandlesFun<InputInteropHandle> getHandlesFun, Func<IntermediaObject, OutputObject> ctorFun,
            InputInteropHandle inputHandle, out OutputObject[] outputHandles)
        {
            outputHandles = null;
            return 0u;
        }
    }
}