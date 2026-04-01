using System.Collections.Generic;
using UnityEngine;

namespace Technie.PhysicsCreator
{
    public class SphereUtils
    {
        private const float kEpsilon = 0.001f;

        private const float kOnePlusEpsilon = 1.001f;

        private static bool PointInsideSphere(Vector3 rkP, Sphere rkS)
        {
            return false;
        }

        private static Sphere ExactSphere1(Vector3 rkP)
        {
            return null;
        }

        private static Sphere ExactSphere2(Vector3 rkP0, Vector3 rkP1)
        {
            return null;
        }

        private static Sphere ExactSphere3(Vector3 rkP0, Vector3 rkP1, Vector3 rkP2)
        {
            return null;
        }

        private static Sphere ExactSphere4(Vector3 rkP0, Vector3 rkP1, Vector3 rkP2, Vector3 rkP3)
        {
            return null;
        }

        private static Sphere UpdateSupport1(int i, List<Vector3> apkPerm, Support rkSupp)
        {
            return null;
        }

        private static Sphere UpdateSupport2(int i, List<Vector3> apkPerm, Support rkSupp)
        {
            return null;
        }

        private static Sphere UpdateSupport3(int i, List<Vector3> apkPerm, Support rkSupp)
        {
            return null;
        }

        public static Sphere UpdateSupport4(int i, List<Vector3> apkPerm, Support rkSupp)
        {
            return null;
        }

        private static Sphere Update(int funcIndex, int numPoints, List<Vector3> points, Support support)
        {
            return null;
        }

        public static Sphere MinSphere(List<Vector3> inputPoints)
        {
            return null;
        }

        public static void Shuffle(List<Vector3> list)
        {
        }

        public class Support
        {
            public int[] m_aiIndex;
            public int m_iQuantity;

            public bool Contains(int iIndex, List<Vector3> points)
            {
                return false;
            }
        }
    }
}