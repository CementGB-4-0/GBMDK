using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Coatsink.Platform.Systems.Online
{
    public static class UnityServiceAuthenticator
    {
        private static bool _isSigningIn;

        [AsyncStateMachine(typeof(_003CTryInitServicesAsync_003Ed__2))]
        public static Task<bool> TryInitServicesAsync(string profileName = null)
        {
            return null;
        }

        [AsyncStateMachine(typeof(_003CTrySignInAsync_003Ed__3))]
        public static Task<bool> TrySignInAsync()
        {
            return null;
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CTryInitServicesAsync_003Ed__2 : IAsyncStateMachine
        {
            public int _003C_003E1__state;

            public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

            public string profileName;

            private Task _003Ctask_003E5__2;

            private TaskAwaiter<Task> _003C_003Eu__1;

            private TaskAwaiter _003C_003Eu__2;

            private void MoveNext()
            {
            }

            void IAsyncStateMachine.MoveNext()
            {
                //ILSpy generated this explicit interface implementation from .override directive in MoveNext
                this.MoveNext();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                //ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
                this.SetStateMachine(stateMachine);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CTrySignInAsync_003Ed__3 : IAsyncStateMachine
        {
            public int _003C_003E1__state;

            public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

            private TaskAwaiter<bool> _003C_003Eu__1;

            private Task _003Ctask_003E5__2;

            private TaskAwaiter<Task> _003C_003Eu__2;

            private TaskAwaiter _003C_003Eu__3;

            private void MoveNext()
            {
            }

            void IAsyncStateMachine.MoveNext()
            {
                //ILSpy generated this explicit interface implementation from .override directive in MoveNext
                this.MoveNext();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                //ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
                this.SetStateMachine(stateMachine);
            }
        }
    }
}