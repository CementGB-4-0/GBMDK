using System;
using System.Collections.Generic;

namespace PartyCSharpSDK
{
    public class DisposableCollection : IDisposable
    {
        private readonly List<IDisposable> disposables;

        public void Dispose()
        {
        }

        private void Dispose(bool isDisposing)
        {
        }

        ~DisposableCollection()
        {
        }

        public T Add<T>(T disposable) where T : IDisposable
        {
            return default(T);
        }
    }
}