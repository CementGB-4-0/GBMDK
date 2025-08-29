using UnityEngine;

namespace Colorful
{
	[ExecuteInEditMode]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/blur-effects/gaussian-blur.html")]
	[AddComponentMenu("Colorful FX/Blur Effects/Gaussian Blur")]
	public class GaussianBlur : BaseEffect
	{
		[Range(0f, 10f)]
		[Tooltip("Amount of blurring pass to apply.")]
		public int Passes;

		[Tooltip("Downscales the result for faster processing or heavier blur.")]
		[Range(1f, 16f)]
		public float Downscaling;

		[Tooltip("Blending factor.")]
		[Range(0f, 1f)]
		public float Amount;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		protected virtual void OnePassBlur(RenderTexture source, RenderTexture destination)
		{
		}

		protected virtual void MultiPassBlur(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
