using System;

namespace PartyCSharpSDK
{
    public class DisposableBuffer : IDisposable
    {
        public DisposableBuffer()
        {
        }

        public DisposableBuffer(int size)
        {
        }

        public IntPtr IntPtr { get; private set; }

        public void Dispose()
        {
        }

        private void Dispose(bool isDisposing)
        {
        }

        ~DisposableBuffer()
        {
        }
    }
}