using UnityEngine;

[ExecuteInEditMode]
public class OpaqueSurfaceFogSceneSettings : MonoBehaviour
{
    public OpaqueSurfaceFogRendererFeature rendererFeature;

    public OpaqueSurfaceFogRendererFeature.OpaqueSurfaceFogSettings settings;

    private void OnValidate()
    {
        UpdateSettings();
    }

    private void UpdateSettings()
    {
        if (rendererFeature)
        {
            rendererFeature.UpdateSettings(settings);
            return;
        }

        Debug.Log(
            "'rendererFeature' is unassigned - assign a reference to the current RenderPipeline's OpaqueSurfaceFogRendererFeature.",
            this);
    }
}