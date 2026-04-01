using System.Collections.Generic;
using UnityEngine;

namespace Technie.PhysicsCreator
{
    public class HullPainter : MonoBehaviour
    {
        public PaintingData paintingData;

        public HullData hullData;

        private Mesh debugMesh;

        private List<HullMapping> hullMapping;

        private void OnDestroy()
        {
        }

        private void OnDrawGizmos()
        {
        }

        public void CreateColliderComponents(Mesh[] autoHulls)
        {
        }

        public void RemoveAllColliders()
        {
        }

        public void RemoveAllGenerated()
        {
        }

        private static bool IsDeletable(GameObject obj)
        {
            return false;
        }

        private static void DestroyImmediateWithUndo(Object obj)
        {
        }

        private void CreateHullMapping()
        {
        }

        private static bool Approximately(Vector3 lhs, Vector3 rhs)
        {
            return false;
        }

        private static bool Approximately(float lhs, float rhs)
        {
            return false;
        }

        private void CreateCollider<T>(Hull sourceHull) where T : Collider
        {
        }

        private void RecreateChildCollider(HullMapping mapping)
        {
        }

        private void RecreateChildCollider<T>(HullMapping mapping) where T : Collider
        {
        }

        private void UpdateCollider(Hull hull)
        {
        }

        public void SetAllTypes(HullType newType)
        {
        }

        public void SetAllMaterials(PhysicMaterial newMaterial)
        {
        }

        public void SetAllAsChild(bool isChild)
        {
        }

        public void SetAllAsTrigger(bool isTrigger)
        {
        }

        private List<T> FindLocal<T>() where T : Component
        {
            return null;
        }

        private bool IsMapped(Hull hull)
        {
            return false;
        }

        private bool IsMapped(Collider col)
        {
            return false;
        }

        private bool IsMapped(HullPainterChild child)
        {
            return false;
        }

        private void AddMapping(Hull hull, Collider col, HullPainterChild painterChild)
        {
        }

        private void RemoveMapping(Hull hull)
        {
        }

        private HullMapping FindMapping(HullPainterChild child)
        {
            return null;
        }

        private HullMapping FindMapping(Hull hull)
        {
            return null;
        }

        public Hull FindSourceHull(HullPainterChild child)
        {
            return null;
        }

        private static Collider FindExistingCollider(List<HullMapping> mappings, Hull hull)
        {
            return null;
        }

        private void CreateAutoHulls(Hull hull, Mesh[] autoHulls)
        {
        }

        private static GameObject CreateGameObject(string goName)
        {
            return null;
        }

        private static T AddComponent<T>(GameObject targetObj) where T : Component
        {
            return null;
        }
    }
}