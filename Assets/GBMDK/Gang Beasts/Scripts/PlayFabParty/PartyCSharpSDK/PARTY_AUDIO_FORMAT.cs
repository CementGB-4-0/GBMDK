namespace PartyCSharpSDK
{
    public class PARTY_AUDIO_FORMAT
    {
        internal PARTY_AUDIO_FORMAT(Interop.PARTY_AUDIO_FORMAT interopStruct)
        {
        }

        public uint SamplesPerSecond { get; }

        public uint ChannelMask { get; }

        public ushort ChannelCount { get; }

        public ushort BitsPerSample { get; }

        public PARTY_AUDIO_SAMPLE_TYPE SampleType { get; }

        public byte Interleaved { get; }
    }
}