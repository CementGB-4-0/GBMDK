using GB.Networking.Utils.Spawn;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(GBSpawnPoint))]
public class GBSpawnPointEditor : Editor
{
    [CanBeNull] private static Mesh _beastMesh;

    [DrawGizmo(GizmoType.Selected | GizmoType.InSelectionHierarchy | GizmoType.NotInSelectionHierarchy)]
    private static void DrawGizmos(GBSpawnPoint spawnPoint, GizmoType gizmoType)
    {
        _beastMesh ??=
            AssetDatabase.LoadAssetAtPath<Mesh>("Assets/GBMDK/Gang Beasts/Meshes/beast_size_reference.asset");
        Gizmos.color = gizmoType.HasFlag(GizmoType.NotInSelectionHierarchy)
            ? new Color(1f, 1f, 1f, 0.05f)
            : new Color(1f, 1f, 1f, 1f);
        Gizmos.DrawWireMesh(_beastMesh, spawnPoint.transform.position,
            Quaternion.Euler(-90, spawnPoint.transform.rotation.eulerAngles.y, 0), Vector3.one);
    }
}