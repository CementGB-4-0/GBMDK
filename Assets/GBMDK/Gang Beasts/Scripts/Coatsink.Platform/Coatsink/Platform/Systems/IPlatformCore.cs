namespace Coatsink.Platform.Systems
{
    public interface IPlatformCore
    {
        PlatformID PlatformID { get; }

        void Initialize(TaskResult<bool> taskResult);

        void UpdateCore();

        void Terminate();
    }
}