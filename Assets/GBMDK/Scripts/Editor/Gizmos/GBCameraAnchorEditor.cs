using GB.View;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(CameraAnchor))]
public class GBCameraAnchorEditor : Editor
{
    [DrawGizmo(GizmoType.Selected | GizmoType.InSelectionHierarchy | GizmoType.NotInSelectionHierarchy)]
    private static void DrawGizmos(CameraAnchor spawnPoint, GizmoType gizmoType)
    {
        Gizmos.color = gizmoType.HasFlag(GizmoType.NotInSelectionHierarchy)
            ? new Color(1f, 1f, 1f, 0.05f)
            : new Color(1f, 1f, 1f, 1f);
        Gizmos.matrix = spawnPoint.transform.localToWorldMatrix;
        Gizmos.DrawFrustum(Vector3.zero, 50f, 10f, 0, 1.5f);
    }
}