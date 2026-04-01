using System;
using System.Collections.Generic;
using UnityEngine;

namespace Technie.PhysicsCreator
{
    [Serializable]
    public class Hull
    {
        public string name;

        public bool isVisible;

        public HullType type;

        public Color colour;

        public PhysicMaterial material;

        public bool enableInflation;

        public float inflationAmount;

        public BoxFitMethod boxFitMethod;

        public bool isTrigger;

        public bool isChildCollider;

        public List<int> selectedFaces;

        public Mesh collisionMesh;

        public Bounds collisionBox;

        public Vector3 boxPosition;

        public Quaternion boxRotation;

        public Mesh faceCollisionMesh;

        public Vector3 faceBoxCenter;

        public Vector3 faceBoxSize;

        public Quaternion faceAsBoxRotation;

        public Mesh[] autoMeshes;

        public bool hasColliderError;

        public int numColliderFaces;

        public Sphere collisionSphere;

        public void Destroy()
        {
        }

        public bool ContainsAutoMesh(Mesh m)
        {
            return false;
        }
    }
}