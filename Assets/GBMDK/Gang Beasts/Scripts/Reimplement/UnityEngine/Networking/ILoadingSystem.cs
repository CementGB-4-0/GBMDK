using UnityEngine.SceneManagement;

namespace UnityEngine.Networking
{
    public interface ILoadingSystem
    {
        bool IsLoading { get; }

        bool IsWaitingActivation { get; }

        void ActivateScene();

        bool IsActivated { get; }

        void CompleteLoad();

        void LoadScene(string map, LoadSceneMode mode);

        float Progression { get; }

        bool IsDone { get; }
    }
}