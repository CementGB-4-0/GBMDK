using System.Collections.Generic;
using UnityEngine;

namespace Technie.PhysicsCreator
{
    public class RotatedBoxFitter
    {
        public void Fit(Hull hull, Vector3[] meshVertices, int[] meshIndices)
        {
        }

        private static void GeneratePlaneVariants(ConstructionPlane basePlane, int numVariants, float angleRange,
            List<ConstructionPlane> variantPlanes)
        {
        }

        public static void ApplyToHull(RotatedBox computedBox, Hull targetHull)
        {
        }

        private static List<RotatedBox> FindTightestBoxes(List<ConstructionPlane> planes, Vector3[] inputVertices)
        {
            return null;
        }

        public static RotatedBox FindTightestBox(ConstructionPlane plane, Vector3[] inputVertices)
        {
            return null;
        }
    }
}