using System.Collections.Generic;
using UnityEngine;

public class MeshCutter
{
    private CuttableMesh inputMesh;

    private List<CuttableSubMesh> outputBackSubMeshes;

    private List<CuttableSubMesh> outputFrontSubMeshes;

    public void Cut(CuttableMesh input, Plane worldCutPlane)
    {
    }

    private static Vector3 ClosestPointOnPlane(Plane plane, Vector3 point)
    {
        return default(Vector3);
    }

    public CuttableMesh GetFrontOutput()
    {
        return null;
    }

    public CuttableMesh GetBackOutput()
    {
        return null;
    }

    private void Cut(CuttableSubMesh inputSubMesh, Plane cutPlane)
    {
    }

    private VertexClassification Classify(Vector3 vertex, Plane cutPlane)
    {
        return default(VertexClassification);
    }

    private void CountSides(VertexClassification c, ref int numFront, ref int numBehind)
    {
    }

    private void KeepTriangle(int i0, int i1, int i2, CuttableSubMesh inputSubMesh, CuttableSubMesh destSubMesh)
    {
    }

    private void SplitA(int i0, int i1, int i2, CuttableSubMesh inputSubMesh, Plane cutPlane,
        CuttableSubMesh frontSubMesh, CuttableSubMesh backSubMesh)
    {
    }

    private void SplitB(int i0, int i1, int i2, CuttableSubMesh inputSubMesh, Plane cutPlane,
        CuttableSubMesh frontSubMesh, CuttableSubMesh backSubMesh)
    {
    }

    private void SplitBFlipped(int i0, int i1, int i2, CuttableSubMesh inputSubMesh, Plane cutPlane,
        CuttableSubMesh frontSubMesh, CuttableSubMesh backSubMesh)
    {
    }

    private Vector3 CalcIntersection(Vector3 v0, Vector3 v1, Plane plane, out float weight)
    {
        weight = default(float);
        return default(Vector3);
    }
}