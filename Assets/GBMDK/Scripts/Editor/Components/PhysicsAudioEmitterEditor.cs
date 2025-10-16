using UnityEditor;

namespace GBMDK.Editor.Components
{
    [CustomEditor(typeof(PhysicAudioEmitter))]
    public class PhysicsAudioEmitterEditor : UnityEditor.Editor
    {
        [MenuItem("Assets/Create/GBMDK/Physics Audio Data")]
        private static void CreateData()
        {
            Common.CreateAndSaveScriptableObject<PhysicsAudioData>();
        }
    }
}