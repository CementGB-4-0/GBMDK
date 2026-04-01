using System;
using System.IO;
using System.Text;

namespace Ionic.Zlib
{
    public class GZipStream : Stream
    {
        internal static readonly DateTime _unixEpoch;

        internal static readonly Encoding iso8859dash1;

        internal ZlibBaseStream _baseStream;

        private string _Comment;

        private int _Crc32;

        private bool _disposed;

        private string _FileName;

        private bool _firstReadDone;

        private int _headerByteCount;
        public DateTime? LastModified;

        public GZipStream(Stream stream, CompressionMode mode)
        {
        }

        public GZipStream(Stream stream, CompressionMode mode, CompressionLevel level)
        {
        }

        public GZipStream(Stream stream, CompressionMode mode, bool leaveOpen)
        {
        }

        public GZipStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
        {
        }

        public string Comment
        {
            get { return null; }
            set { }
        }

        public string FileName
        {
            get { return null; }
            set { }
        }

        public int Crc32 => 0;

        public virtual FlushType FlushMode
        {
            get { return default(FlushType); }
            set { }
        }

        public int BufferSize
        {
            get { return 0; }
            set { }
        }

        public virtual long TotalIn => 0L;

        public virtual long TotalOut => 0L;

        public override bool CanRead => false;

        public override bool CanSeek => false;

        public override bool CanWrite => false;

        public override long Length => 0L;

        public override long Position
        {
            get { return 0L; }
            set { }
        }

        protected override void Dispose(bool disposing)
        {
        }

        public override void Flush()
        {
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            return 0;
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return 0L;
        }

        public override void SetLength(long value)
        {
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
        }

        private int EmitHeader()
        {
            return 0;
        }

        public static byte[] CompressString(string s)
        {
            return null;
        }

        public static byte[] CompressBuffer(byte[] b)
        {
            return null;
        }

        public static string UncompressString(byte[] compressed)
        {
            return null;
        }

        public static byte[] UncompressBuffer(byte[] compressed)
        {
            return null;
        }
    }
}