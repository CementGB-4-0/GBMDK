using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
#if UNITY_EDITOR
using GBMDK.Editor;
#endif

public class OpaqueSurfaceFogRendererFeature : ScriptableRendererFeature
{
    [SerializeField] private OpaqueSurfaceFogSettings opaqueFogSettings;

    private readonly int idFogColor = Shader.PropertyToID("_FogColor");

    private readonly int idFogLightScatterIntensity = Shader.PropertyToID("_FogLightScatterIntensity");

    private readonly int idGroundFogElevation = Shader.PropertyToID("_GroundFogElevation");

    private readonly int idGroundFogMaxDepth = Shader.PropertyToID("_GroundFogMaxDepth");

    private readonly int idSkyColor = Shader.PropertyToID("_SkyColor");

    private readonly int idSkyFogElevation = Shader.PropertyToID("_SkyFogElevation");

    private readonly int idSkyFogMaxDepth = Shader.PropertyToID("_SkyFogMaxDepth");

    private Shader opaqueFogShader;

    private OpaqueSurfaceFogRenderPass renderPass;

    private void OnValidate()
    {
        UpdateGlobalShaderProperties();
    }

    public void UpdateSettings(OpaqueSurfaceFogSettings settings)
    {
        opaqueFogSettings = settings;
        UpdateGlobalShaderProperties();
    }

    public override void Create()
    {
        renderPass = new OpaqueSurfaceFogRenderPass("OpaqueSurfaceFog");
        InitializeRenderPassBlitMaterial();
    }

    public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
    {
        if (renderingData.cameraData.renderType == CameraRenderType.Base)
        {
            InitializeRenderPassBlitMaterial();
            var cameraColorTarget = renderer.cameraColorTarget;
            renderPass.Setup(cameraColorTarget);
            renderer.EnqueuePass(renderPass);
        }
    }

    private async void InitializeRenderPassBlitMaterial()
    {
#if UNITY_EDITOR
        opaqueFogShader =
            ShaderViewer.CachedShaders.FirstOrDefault(sh => sh.name == "Hidden/GangBeasts/OpaqueSurfaceFog") ??
            Shader.Find("Hidden/GangBeasts/OpaqueSurfaceFog");
        if (renderPass != null) renderPass.InitializeBlitMaterial(opaqueFogShader);
#endif
    }

    private void UpdateGlobalShaderProperties()
    {
        Shader.SetGlobalColor(idSkyColor, opaqueFogSettings.skyColor);
        Shader.SetGlobalColor(idFogColor, opaqueFogSettings.fogColor);
        Shader.SetGlobalFloat(idFogLightScatterIntensity, opaqueFogSettings.fogLightScatterIntensity);
        Shader.SetGlobalFloat(idSkyFogMaxDepth, opaqueFogSettings.skyFogMaxDepth);
        Shader.SetGlobalFloat(idSkyFogElevation, opaqueFogSettings.skyFogElevation);
        Shader.SetGlobalFloat(idGroundFogMaxDepth, opaqueFogSettings.groundFogMaxDepth);
        Shader.SetGlobalFloat(idGroundFogElevation, opaqueFogSettings.groundFogElevation);
    }

    [Serializable]
    public struct OpaqueSurfaceFogSettings
    {
        [ColorUsage(false, true)] public Color skyColor;

        [ColorUsage(false, true)] public Color fogColor;

        [Range(0f, 1f)] public float fogLightScatterIntensity;

        [Min(0.001f)] public float skyFogMaxDepth;

        [Min(0.001f)] public float skyFogElevation;

        [Min(0.001f)] public float groundFogMaxDepth;

        public float groundFogElevation;
    }

    private class OpaqueSurfaceFogRenderPass : ScriptableRenderPass
    {
        private readonly int idViewDirBL = Shader.PropertyToID("_ViewDirBL");

        private readonly int idViewDirBR = Shader.PropertyToID("_ViewDirBR");

        private readonly int idViewDirTL = Shader.PropertyToID("_ViewDirTL");

        private readonly int idViewDirTR = Shader.PropertyToID("_ViewDirTR");

        private readonly string profilerTag;

        private Material blitMaterial;

        public OpaqueSurfaceFogRenderPass(string profilerTag)
        {
            renderPassEvent = URPConstants.renderPassEventOpaqueFog;
            this.profilerTag = profilerTag;
        }

        private RenderTargetIdentifier Source { get; set; }

        public void Setup(RenderTargetIdentifier source)
        {
            Source = source;
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            if (!blitMaterial) return;

            var commandBuffer = CommandBufferPool.Get(profilerTag);
            UpdateGlobalShaderProperties(commandBuffer, ref renderingData);
            Blit(commandBuffer, Source, Source, blitMaterial);
            context.ExecuteCommandBuffer(commandBuffer);
            commandBuffer.Clear();
            CommandBufferPool.Release(commandBuffer);
        }

        public void InitializeBlitMaterial(Shader blitShader)
        {
            if (!blitMaterial)
            {
                blitMaterial = new Material(blitShader);
                blitMaterial.name = "OpaqueSurfaceFog";
            }
        }

        private void UpdateGlobalShaderProperties(CommandBuffer cmd, ref RenderingData renderingData)
        {
            var inverse = (renderingData.cameraData.camera.projectionMatrix *
                           renderingData.cameraData.camera.worldToCameraMatrix).inverse;
            var camera = renderingData.cameraData.camera;
            var position = camera.transform.position;
            var farClipPlane = camera.farClipPlane;
            var worldViewDirection = GetWorldViewDirection(-1f, -1f, inverse, position, farClipPlane);
            var worldViewDirection2 = GetWorldViewDirection(1f, -1f, inverse, position, farClipPlane);
            var worldViewDirection3 = GetWorldViewDirection(-1f, 1f, inverse, position, farClipPlane);
            var worldViewDirection4 = GetWorldViewDirection(1f, 1f, inverse, position, farClipPlane);
            cmd.SetGlobalVector(idViewDirBL, worldViewDirection);
            cmd.SetGlobalVector(idViewDirBR, worldViewDirection2);
            cmd.SetGlobalVector(idViewDirTL, worldViewDirection3);
            cmd.SetGlobalVector(idViewDirTR, worldViewDirection4);
        }

        private Vector3 GetWorldViewDirection(float horizontalClipPos, float verticalClipPos, Matrix4x4 inverseVPMatrix,
            Vector3 cameraWorldPosition, float cameraFarPlaneDistance)
        {
            var vector = inverseVPMatrix * new Vector4(horizontalClipPos, verticalClipPos, 1f, 1f);
            return (new Vector3(vector.x, vector.y, vector.z) / vector.w - cameraWorldPosition) /
                   cameraFarPlaneDistance;
        }
    }
}