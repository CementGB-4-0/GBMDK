using System;
using System.Runtime.InteropServices;

namespace CS.CorePlatform
{
    public static class PlatformLibs
    {
        [PreserveSig]
        public static extern IntPtr FindWindow(string className, string windowName);

        public static IntPtr GetWindowHandle()
        {
            return (IntPtr)0;
        }

        [PreserveSig]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        [PreserveSig]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);

        [PreserveSig]
        private static extern uint GetCurrentThreadId();

        [PreserveSig]
        private static extern IntPtr GetForegroundWindow();

        [PreserveSig]
        private static extern bool AttachThreadInput(uint idAttach, uint idAttachTo, bool fAttach);

        [PreserveSig]
        private static extern bool BringWindowToTop(IntPtr hWnd);

        [PreserveSig]
        private static extern bool BringWindowToTop(HandleRef hWnd);

        [PreserveSig]
        private static extern bool ShowWindow(IntPtr hWnd, uint nCmdShow);

        public static bool GetFocus()
        {
            return false;
        }
    }
}