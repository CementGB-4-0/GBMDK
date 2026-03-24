namespace Coatsink.Platform.Systems.UI
{
    public interface IUIPopUpManager
    {
        void Show(IDisplayTask taskResult);

        void Closed();
    }
}