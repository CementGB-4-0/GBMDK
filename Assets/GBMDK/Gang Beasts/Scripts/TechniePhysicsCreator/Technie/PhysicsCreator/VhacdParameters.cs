using System;
using UnityEngine;

namespace Technie.PhysicsCreator
{
    [Serializable]
    public class VhacdParameters
    {
        [Tooltip("maximum concavity")] [Range(0f, 1f)]
        public float concavity;

        [Tooltip("controls the bias toward clipping along symmetry planes")] [Range(0f, 1f)]
        public float alpha;

        [Tooltip("controls the bias toward clipping along revolution axes")] [Range(0f, 1f)]
        public float beta;

        [Tooltip("controls the adaptive sampling of the generated convex-hulls")] [Range(0f, 0.01f)]
        public float minVolumePerCH;

        [Tooltip("maximum number of voxels generated during the voxelization stage")] [Range(10000f, 64000000f)]
        public uint resolution;

        [Tooltip("controls the maximum number of triangles per convex-hull")] [Range(4f, 1024f)]
        public uint maxNumVerticesPerCH;

        [Range(1f, 16f)] [Tooltip("controls the granularity of the search for the \"best\" clipping plane")]
        public uint planeDownsampling;

        [Tooltip(
            "controls the precision of the convex-hull generation process during the clipping plane selection stage")]
        [Range(1f, 16f)]
        public uint convexhullDownsampling;

        [Tooltip("enable/disable normalizing the mesh before applying the convex decomposition")] [Range(0f, 1f)]
        public uint pca;

        [Tooltip("0: voxel-based (recommended), 1: tetrahedron-based")] [Range(0f, 1f)]
        public uint mode;

        [Range(0f, 1f)] public uint convexhullApproximation;

        [Tooltip("Enable OpenCL acceleration")] [Range(0f, 1f)]
        public uint oclAcceleration;

        public uint maxConvexHulls;

        [Tooltip(
            "This will project the output convex hull vertices onto the original source mesh to increase the floating point accuracy of the results")]
        public bool projectHullVertices;
    }
}