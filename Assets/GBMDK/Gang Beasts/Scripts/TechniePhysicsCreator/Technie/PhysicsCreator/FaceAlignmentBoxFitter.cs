using System.Collections.Generic;
using UnityEngine;

namespace Technie.PhysicsCreator
{
    public class FaceAlignmentBoxFitter
    {
        public void Fit(Hull hull, Vector3[] meshVertices, int[] meshIndices)
        {
        }

        public static List<Triangle> FindTriangles(Vector3[] meshVertices, int[] meshIndices, List<int> selectedFaces)
        {
            return null;
        }

        public static void FindTriangles(Hull hull, Vector3[] meshVertices, int[] meshIndices,
            out Vector3[] hullVertices, out int[] hullIndices)
        {
            hullVertices = null;
            hullIndices = null;
        }

        public static Vector3[] GetSelectedVertices(Hull hull, Vector3[] meshVertices, int[] meshIndices)
        {
            return null;
        }

        private TriangleBucket FindBestBucket(Triangle tri, float thresholdAngleDeg, List<TriangleBucket> buckets)
        {
            return null;
        }

        private void MergeClosestBuckets(List<TriangleBucket> buckets)
        {
        }

        private ConstructionPlane CreateConstructionPlane(TriangleBucket primaryBucket, TriangleBucket secondaryBucket,
            TriangleBucket tertiaryBucket)
        {
            return null;
        }
    }
}