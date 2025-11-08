Shader "Particles/Standard Surface But Color Is Emission"
{
    Properties
    {
        _MainTex ("Albedo", 2D) = "white" {}
        _Color ("Color", Vector) = (1,1,1,1)
        _Cutoff ("Alpha Cutoff", Range(0, 1)) = 0.5
        _MetallicGlossMap ("Metallic", 2D) = "white" {}
        [Gamma] _Metallic ("Metallic", Range(0, 1)) = 0
        _Glossiness ("Smoothness", Range(0, 1)) = 0.5
        _BumpScale ("Scale", Float) = 1
        _BumpMap ("Normal Map", 2D) = "bump" {}
        _EmissionColor ("Color", Vector) = (0,0,0,1)
        _EmissionMap ("Emission", 2D) = "white" {}
        _DistortionStrength ("Strength", Float) = 1
        _DistortionBlend ("Blend", Range(0, 1)) = 0.5
        _SoftParticlesNearFadeDistance ("Soft Particles Near Fade", Float) = 0
        _SoftParticlesFarFadeDistance ("Soft Particles Far Fade", Float) = 1
        _CameraNearFadeDistance ("Camera Near Fade", Float) = 1
        _CameraFarFadeDistance ("Camera Far Fade", Float) = 2
        [HideInInspector] _Mode ("__mode", Float) = 0
        [HideInInspector] _FlipbookMode ("__flipbookmode", Float) = 0
        [HideInInspector] _LightingEnabled ("__lightingenabled", Float) = 1
        [HideInInspector] _DistortionEnabled ("__distortionenabled", Float) = 0
        [HideInInspector] _EmissionEnabled ("__emissionenabled", Float) = 0
        [HideInInspector] _BlendOp ("__blendop", Float) = 0
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
        [HideInInspector] _ZWrite ("__zw", Float) = 1
        [HideInInspector] _Cull ("__cull", Float) = 2
        [HideInInspector] _SoftParticlesEnabled ("__softparticlesenabled", Float) = 0
        [HideInInspector] _CameraFadingEnabled ("__camerafadingenabled", Float) = 0
        [HideInInspector] _SoftParticleFadeParams ("__softparticlefadeparams", Vector) = (0,0,0,0)
        [HideInInspector] _CameraFadeParams ("__camerafadeparams", Vector) = (0,0,0,0)
        [HideInInspector] _DistortionStrengthScaled ("__distortionstrengthscaled", Float) = 0
    }
    //DummyShaderTextExporter
    SubShader
    {
        Tags
        {
            "RenderType"="Opaque" "RenderPipeline"="UniversalPipeline"
        }
        LOD 200

        Pass
        {
            HLSLPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            float4 _MainTex_ST;

            struct Vertex_Stage_Input
            {
                float4 pos : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct Vertex_Stage_Output
            {
                float2 uv : TEXCOORD0;
                float4 pos : SV_POSITION;
            };

            Vertex_Stage_Output vert(Vertex_Stage_Input input)
            {
                Vertex_Stage_Output output;
                output.uv = (input.uv.xy * _MainTex_ST.xy) + _MainTex_ST.zw;
                output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
                return output;
            }

            Texture2D<float4> _MainTex;
            SamplerState sampler_MainTex;
            float4 _Color;

            struct Fragment_Stage_Input
            {
                float2 uv : TEXCOORD0;
            };

            float4 frag(Fragment_Stage_Input input) : SV_TARGET
            {
                return _MainTex.Sample(sampler_MainTex, input.uv.xy) * _Color;
            }
            ENDHLSL
        }
    }
    Fallback "VertexLit"
    //CustomEditor "StandardParticlesShaderGUI"
}