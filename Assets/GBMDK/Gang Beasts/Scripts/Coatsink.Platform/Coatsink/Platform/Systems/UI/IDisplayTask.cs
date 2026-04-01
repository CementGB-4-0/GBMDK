using System.ComponentModel;

namespace Coatsink.Platform.Systems.UI
{
    public interface IDisplayTask
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        bool YesNo { get; set; }

        string Message { get; }

        bool Closed { get; set; }

        bool Result { set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        void Enqueued();

        [EditorBrowsable(EditorBrowsableState.Never)]
        void Finish(uint code);
    }
}