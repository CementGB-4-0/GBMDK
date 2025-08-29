using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class KawaseBlur : ScriptableRendererFeature
{
	[Serializable]
	public class KawaseBlurSettings
	{
		public enum BlurSize
		{
			VerySmall = 0,
			Small = 1,
			Medium = 2,
			Large = 3,
			VeryLarge = 4,
			Extreme = 5
		}

		public RenderPassEvent renderPassEvent;

		public Material blurMaterial;

		public Material blurCompositeMaterial;

		public BlurSize blurSize;

		[Range(1f, 8f)]
		public int downsample;

		public bool copyToFramebuffer;

		public string targetName;
	}

	private class CustomRenderPass : ScriptableRenderPass
	{
		public Material blurMaterial;

		public Material blurCompositeMaterial;

		public KawaseBlurSettings.BlurSize blurSize;

		public int downsample;

		public bool copyToFramebuffer;

		public string targetName;

		private string profilerTag;

		private float blurAmount;

		private int tmpId1;

		private int tmpId2;

		private readonly int idOffset;

		private readonly int idAlpha;

		private RenderTargetIdentifier tmpRT1;

		private RenderTargetIdentifier tmpRT2;

		private readonly float[] FilterSizeVerySmall;

		private readonly float[] FilterSizeSmall;

		private readonly float[] FilterSizeMedium;

		private readonly float[] FilterSizeLarge;

		private readonly float[] FilterSizeVeryLarge;

		private readonly float[] FilterSizeExtreme;

		private RenderTargetIdentifier source { get; set; }

		public void Setup(RenderTargetIdentifier source, float blurAmount)
		{
		}

		public CustomRenderPass(string profilerTag)
		{
		}

		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}

	public KawaseBlurSettings settings;

	public static Action<bool> OnBlurSet;

	public static bool enableBlur;

	private CustomRenderPass scriptablePass;

	public static bool EnableBlur
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static float BlurAmount { get; set; }

	public static Camera BlurCamera { get; set; }

	public override void Create()
	{
	}

	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}
}
