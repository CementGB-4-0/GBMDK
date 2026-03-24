using UnityEngine;

namespace Technie.PhysicsCreator
{
    public class RotatedBox
    {
        public Vector3 center;

        public Vector3 localCenter;
        public ConstructionPlane plane;

        public Vector3 size;

        public float volume;

        public RotatedBox(ConstructionPlane p, Vector3 localCenter, Vector3 c, Vector3 s)
        {
        }

        public float VolumeCm3 => 0f;
    }
}