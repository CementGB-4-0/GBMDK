Shader "UVFree/StandardSpecular/Top-Bottom-Texture"
{
    Properties
    {
        [HideInInspector] _TriplanarSpace ("Triplanar Space", Float) = 0
        _TexPower ("Texture Power", Range(0, 20)) = 10
        _TopMultiplier ("Top Multiplier", Range(0, 8)) = 1
        _BottomMultiplier ("Bottom Multiplier", Range(0, 8)) = 0
        _VertexColorStrength ("Vertex Color Strength", Range(0, 1)) = 1
        _Color ("Color", Vector) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _Glossiness ("Smoothness", Range(0, 1)) = 0.5
        _SpecColor ("Specular", Vector) = (0.2,0.2,0.2,1)
        _SpecGlossMap ("Specular", 2D) = "white" {}
        _UsingSpecGlossMap ("Using Spec Gloss Map", Float) = 0
        _BumpScale ("Bump Scale", Float) = 1
        _BumpMap ("Normal Map", 2D) = "bump" {}
        _EmissionColor ("Emission Color", Vector) = (0,0,0,1)
        _EmissionMap ("Emission", 2D) = "white" {}
        [HideInInspector] _EmissionScaleUI ("Scale", Float) = 0
        [HideInInspector] _EmissionColorUI ("Color", Vector) = (1,1,1,1)
        _TopColor ("Color", Vector) = (1,1,1,1)
        _TopMainTex ("Albedo (RGB)", 2D) = "white" {}
        _TopGlossiness ("Smoothness", Range(0, 1)) = 0.5
        _TopSpecColor ("Specular", Vector) = (0.2,0.2,0.2,1)
        _TopSpecGlossMap ("Specular", 2D) = "white" {}
        _TopUsingSpecGlossMap ("Using Spec Gloss Map", Float) = 0
        _TopBumpScale ("Bump Scale", Float) = 1
        _TopBumpMap ("Normal Map", 2D) = "bump" {}
        _TopEmissionColor ("Emission Color", Vector) = (0,0,0,1)
        _TopEmissionMap ("Emission", 2D) = "white" {}
        [HideInInspector] _TopEmissionScaleUI ("Scale", Float) = 0
        [HideInInspector] _TopEmissionColorUI ("Color", Vector) = (1,1,1,1)
        _BottomColor ("Color", Vector) = (1,1,1,1)
        _BottomMainTex ("Albedo (RGB)", 2D) = "white" {}
        _BottomGlossiness ("Smoothness", Range(0, 1)) = 0.5
        _BottomSpecColor ("Specular", Vector) = (0.2,0.2,0.2,1)
        _BottomSpecGlossMap ("Specular", 2D) = "white" {}
        _BottomUsingSpecGlossMap ("Using Spec Gloss Map", Float) = 0
        _BottomBumpScale ("Bump Scale", Float) = 1
        _BottomBumpMap ("Normal Map", 2D) = "bump" {}
        _BottomEmissionColor ("Emission Color", Vector) = (0,0,0,1)
        _BottomEmissionMap ("Emission", 2D) = "white" {}
        [HideInInspector] _BottomEmissionScaleUI ("Scale", Float) = 0
        [HideInInspector] _BottomEmissionColorUI ("Color", Vector) = (1,1,1,1)
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
    Fallback "Diffuse"
    //CustomEditor "UVFreePBRShaderTopBottomGUI"
}