using System.Collections.Generic;
using UnityEngine;

public class CuttableSubMesh
{
    private List<Color32> colours;

    private List<Vector3> normals;

    private List<Vector2> uv1s;

    private List<Vector2> uvs;
    private List<Vector3> vertices;

    public CuttableSubMesh(bool hasNormals, bool hasColours, bool hasUvs, bool hasUv1)
    {
    }

    public CuttableSubMesh(int[] indices, Vector3[] inputVertices, Vector3[] inputNormals, Color32[] inputColours,
        Vector2[] inputUvs, Vector2[] inputUv1)
    {
    }

    public void Add(CuttableSubMesh other)
    {
    }

    public int NumVertices()
    {
        return 0;
    }

    public Vector3 GetVertex(int index)
    {
        return default(Vector3);
    }

    public bool HasNormals()
    {
        return false;
    }

    public bool HasColours()
    {
        return false;
    }

    public bool HasUvs()
    {
        return false;
    }

    public bool HasUv1()
    {
        return false;
    }

    public void CopyVertex(int srcIndex, CuttableSubMesh srcMesh)
    {
    }

    public void AddInterpolatedVertex(int i0, int i1, float weight, CuttableSubMesh srcMesh)
    {
    }

    public void AddTo(List<Vector3> destVertices, List<Vector3> destNormals, List<Color32> destColours,
        List<Vector2> destUvs, List<Vector2> destUv1s)
    {
    }

    public int NumIndices()
    {
        return 0;
    }

    public int[] GenIndices()
    {
        return null;
    }
}