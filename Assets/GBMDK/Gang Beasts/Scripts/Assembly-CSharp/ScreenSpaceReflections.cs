using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class ScreenSpaceReflections : ScriptableRendererFeature
{
	public enum ScreenSpaceReflectionPreset
	{
		Lower = 0,
		Low = 1,
		Medium = 2,
		High = 3,
		Higher = 4,
		Ultra = 5,
		Overkill = 6,
		Custom = 7
	}

	public enum ScreenSpaceReflectionResolution
	{
		Downsampled = 0,
		FullSize = 1,
		Supersampled = 2
	}

	public class RenderGBuffer : ScriptableRenderPass
	{
		private ProfilingSampler m_ProfilingSampler;

		private FilteringSettings m_FilteringSettings;

		private List<ShaderTagId> m_ShaderTagIdList;

		private RenderTargetHandle m_DepthTexture;

		private RenderTargetHandle[] m_GBufferHandles;

		private RenderTargetIdentifier[] m_GBufferIdentifiers;

		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}
	}

	public class RenderReflections : ScriptableRenderPass
	{
		public struct QualitySettings
		{
			public int maximumIterationCount;

			public float thickness;

			public ScreenSpaceReflectionResolution downsampling;
		}

		private enum Pass
		{
			Test = 0,
			Resolve = 1,
			Reproject = 2,
			Composite = 3
		}

		private class ShaderIds
		{
			internal static readonly int SSRResolveTemp;

			internal static readonly int NoiseId;

			internal static readonly int Test;

			internal static readonly int Resolve;

			internal static readonly int MainTex;

			internal static readonly int History;

			internal static readonly int ViewMatrix;

			internal static readonly int InverseViewMatrix;

			internal static readonly int InverseProjectionMatrix;

			internal static readonly int ScreenSpaceProjectionMatrix;

			internal static readonly int Params;

			internal static readonly int Params2;
		}

		public static readonly QualitySettings[] QualityPresets;

		private ProfilingSampler m_ProfilingSampler;

		private RenderTargetHandle m_GBufferColor;

		private RenderTargetHandle m_GBufferNormalsWS_Smoothness;

		private RenderTexture m_Resolve;

		private RenderTexture m_History;

		private int[] m_MipIDs;

		private Material m_ScreenSpaceReflectionMaterial;

		private ComputeShader m_GuassianDownsample;

		private Texture2D m_BlueNoise256;

		private RenderTargetIdentifier m_Source;

		private RenderTargetHandle m_OpaqueColor;

		private Material m_BlitMaterial;

		private bool m_ResetHistory;

		private QualitySettings m_settings;

		private float m_MaximumMarchDistance;

		private float m_Vignette;

		private float m_DistanceFade;

		private readonly GraphicsFormat ReflectionsGraphicsFormat;

		private readonly RenderTextureFormat ReflectionsTextureFormat;

		public RenderReflections(Material screenSpaceReflectionShader, ComputeShader guassianDownsample, Texture2D blueNoises256)
		{
		}

		internal void CheckRT(ref RenderTexture rt, int width, int height, FilterMode filterMode, bool useMipMap, RenderTextureFormat format)
		{
		}

		public void Setup(RenderTargetIdentifier source, QualitySettings settings, float maximumMarchDistance, float vignette, float distanceFade)
		{
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}

	[Tooltip("Choose a quality preset, or use \"Custom\" to create your own custom preset. Don't use a preset higher than \"Medium\" if you desire good performance on consoles.")]
	public ScreenSpaceReflectionPreset preset;

	[Tooltip("Maximum number of steps in the raymarching pass. Higher values mean more reflections.")]
	[Range(0f, 256f)]
	public int maximumIterationCount;

	[Tooltip("Changes the size of the SSR buffer. Downsample it to maximize performances or supersample it for higher quality results with reduced performance.")]
	public ScreenSpaceReflectionResolution resolution;

	[Range(1f, 64f)]
	[Tooltip("Ray thickness. Lower values are more expensive but allow the effect to detect smaller details.")]
	public float thickness;

	[Tooltip("Maximum distance to traverse after which it will stop drawing reflections.")]
	public float maximumMarchDistance;

	[Tooltip("Fades reflections close to the near planes.")]
	[Range(0f, 1f)]
	public float distanceFade;

	[Range(0f, 1f)]
	[Tooltip("Fades reflections close to the screen edges.")]
	public float vignette;

	public Texture2D blueNoise256;

	public Material ScreenSpaceReflectionsMaterial;

	public ComputeShader GaussianDownsample;

	private RenderGBuffer m_RenderGBufferPass;

	private RenderReflections m_RenderReflectionsPass;

	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}

	public override void Create()
	{
	}
}
