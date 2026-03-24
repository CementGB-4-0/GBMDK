using System.Collections.Generic;
using UnityEngine;

namespace Technie.PhysicsCreator
{
    public class PaintingData : ScriptableObject
    {
        public HullData hullData;

        public Mesh sourceMesh;

        public int activeHull;

        public float faceThickness;

        public List<Hull> hulls;

        public AutoHullPreset autoHullPreset;

        public VhacdParameters vhacdParams;

        public bool hasLastVhacdTimings;

        public AutoHullPreset lastVhacdPreset;

        public float lastVhacdDurationSecs;
        public readonly Color[] hullColours;

        public int TotalOutputColliders => 0;

        public void AddHull(HullType type, PhysicMaterial material, bool isChild, bool isTrigger)
        {
        }

        public void RemoveHull(int index)
        {
        }

        public void RemoveAllHulls()
        {
        }

        public bool HasActiveHull()
        {
            return false;
        }

        public Hull GetActiveHull()
        {
            return null;
        }

        public void GenerateCollisionMesh(Hull hull, Vector3[] meshVertices, int[] meshIndices, Mesh[] autoHulls)
        {
        }

        private Mesh Clip(Mesh boundingMesh, Mesh inputMesh)
        {
            return null;
        }

        private Plane[] ConvertToPlanes(Mesh convexMesh, bool show)
        {
            return null;
        }

        private static bool Contains(Plane toTest, List<Plane> planes)
        {
            return false;
        }

        private Vector3 CalcPrimaryAxis(Hull hull, Vector3[] meshVertices, int[] meshIndices, bool snapToAxies)
        {
            return default(Vector3);
        }

        private Vector3[] ExtractUniqueVertices(Hull hull, Vector3[] meshVertices, int[] meshIndices)
        {
            return null;
        }

        private static bool Contains(List<Vector3> list, Vector3 p)
        {
            return false;
        }

        private static float CalcRequiredArea(float angleDeg, Vector3 primaryAxis, Vector3 primaryUp,
            Vector3[] vertices, out Vector3 min, out Vector3 max, out Quaternion outBasis)
        {
            min = default(Vector3);
            max = default(Vector3);
            outBasis = default(Quaternion);
            return 0f;
        }

        private bool CalculateBoundingSphere(Hull hull, Vector3[] meshVertices, int[] meshIndices,
            out Vector3 sphereCenter, out float sphereRadius)
        {
            sphereCenter = default(Vector3);
            sphereRadius = default(float);
            return false;
        }

        private void GenerateConvexHull(Hull hull, Vector3[] meshVertices, int[] meshIndices, Mesh destMesh)
        {
        }

        private void GenerateFace(Hull hull, Vector3[] meshVertices, int[] meshIndices, float thickness)
        {
        }

        public bool ContainsMesh(Mesh m)
        {
            return false;
        }

        private static void Inflate(Vector3 point, ref Vector3 min, ref Vector3 max)
        {
        }

        public bool HasAutoHulls()
        {
            return false;
        }
    }
}