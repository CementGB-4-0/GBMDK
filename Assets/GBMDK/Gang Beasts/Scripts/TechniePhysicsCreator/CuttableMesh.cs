using System.Collections.Generic;
using UnityEngine;

public class CuttableMesh
{
    private bool hasColours;

    private bool hasUv1s;

    private bool hasUvs;
    private MeshRenderer inputMeshRenderer;

    private List<CuttableSubMesh> subMeshes;

    public CuttableMesh(Mesh inputMesh)
    {
    }

    public CuttableMesh(MeshRenderer input)
    {
    }

    public CuttableMesh(CuttableMesh inputMesh, List<CuttableSubMesh> newSubMeshes)
    {
    }

    private void Init(Mesh inputMesh, string debugName)
    {
    }

    public void Add(CuttableMesh other)
    {
    }

    public int NumSubMeshes()
    {
        return 0;
    }

    public bool HasUvs()
    {
        return false;
    }

    public bool HasColours()
    {
        return false;
    }

    public List<CuttableSubMesh> GetSubMeshes()
    {
        return null;
    }

    public CuttableSubMesh GetSubMesh(int index)
    {
        return null;
    }

    public Transform GetTransform()
    {
        return null;
    }

    public MeshRenderer ConvertToRenderer(string newObjectName)
    {
        return null;
    }

    public Mesh CreateMesh()
    {
        return null;
    }
}