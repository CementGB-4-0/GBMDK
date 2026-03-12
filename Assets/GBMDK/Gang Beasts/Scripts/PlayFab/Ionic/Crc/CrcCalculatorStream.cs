using System;
using System.IO;

namespace Ionic.Crc
{
    public class CrcCalculatorStream : Stream, IDisposable
    {
        private static readonly long UnsetLengthLimit;

        private CRC32 _Crc32;

        internal Stream _innerStream;

        private bool _leaveOpen;

        private long _lengthLimit;

        public CrcCalculatorStream(Stream stream)
        {
        }

        public CrcCalculatorStream(Stream stream, bool leaveOpen)
        {
        }

        public CrcCalculatorStream(Stream stream, long length)
        {
        }

        public CrcCalculatorStream(Stream stream, long length, bool leaveOpen)
        {
        }

        public CrcCalculatorStream(Stream stream, long length, bool leaveOpen, CRC32 crc32)
        {
        }

        private CrcCalculatorStream(bool leaveOpen, long length, Stream stream, CRC32 crc32)
        {
        }

        public long TotalBytesSlurped => 0L;

        public int Crc => 0;

        public bool LeaveOpen
        {
            get { return false; }
            set { }
        }

        public override bool CanRead => false;

        public override bool CanSeek => false;

        public override bool CanWrite => false;

        public override long Length => 0L;

        public override long Position
        {
            get { return 0L; }
            set { }
        }

        void IDisposable.Dispose()
        {
            //ILSpy generated this explicit interface implementation from .override directive in Dispose
            this.Dispose();
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            return 0;
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
        }

        public override void Flush()
        {
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return 0L;
        }

        public override void SetLength(long value)
        {
        }

        private new void Dispose()
        {
        }

        public override void Close()
        {
        }
    }
}