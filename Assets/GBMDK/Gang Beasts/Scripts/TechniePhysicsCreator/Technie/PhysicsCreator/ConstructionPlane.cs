using UnityEngine;

namespace Technie.PhysicsCreator
{
    public class ConstructionPlane
    {
        public Vector3 center;

        public Vector3 normal;

        public Matrix4x4 planeToWorld;

        public Quaternion rotation;

        public Vector3 tangent;

        public Matrix4x4 worldToPlane;

        public ConstructionPlane(Vector3 c, Vector3 n, Vector3 t)
        {
        }

        public ConstructionPlane(ConstructionPlane basePlane, float angle)
        {
        }

        private void Init()
        {
        }
    }
}