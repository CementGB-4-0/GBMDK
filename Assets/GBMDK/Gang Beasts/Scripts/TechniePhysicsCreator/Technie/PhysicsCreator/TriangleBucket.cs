using System.Collections.Generic;
using UnityEngine;

namespace Technie.PhysicsCreator
{
    public class TriangleBucket
    {
        private Vector3 averagedCenter;

        private Vector3 averagedNormal;

        private float totalArea;
        private List<Triangle> triangles;

        public TriangleBucket(Triangle initialTriangle)
        {
        }

        public float Area => 0f;

        public void Add(Triangle t)
        {
        }

        public void Add(TriangleBucket otherBucket)
        {
        }

        private void CalculateNormal()
        {
        }

        public Vector3 GetAverageNormal()
        {
            return default(Vector3);
        }

        public Vector3 GetAverageCenter()
        {
            return default(Vector3);
        }

        private void CalcTotalArea()
        {
        }
    }
}