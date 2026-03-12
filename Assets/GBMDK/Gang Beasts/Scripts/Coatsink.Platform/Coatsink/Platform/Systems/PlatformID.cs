using System;

namespace Coatsink.Platform.Systems
{
    [Serializable]
    [Flags]
    public enum PlatformID : byte
    {
        UNKNOWN = 0,
        PC = 1,
        CONSOLE = 2,
        NONE = 5,
        STEAM = 9,
        DISCORD = 0x11,
        GOG = 0x21,
        OCULUS = 0x41,
        MSGAMEPASS = 0x81,
        XBOX = 6,
        SONY = 0xA,
        NINTENDO = 0x12,
        STADIA = 0x22,
        GDK = 7
    }
}