using System;

namespace Coatsink.Platform
{
    [Flags]
    public enum TaskState
    {
        IDLE = 0,
        COMPLETE = 2,
        SUCCESSFUL = 4,
        ACTIVE = 8,
        FINALISED = 0x10
    }
}