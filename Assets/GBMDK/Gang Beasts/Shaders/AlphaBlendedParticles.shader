Shader "GangBeasts/Particles/AlphaBlendedParticles"
{
    Properties
    {
        [HDR] _Color ("Color", Vector) = (1,1,1,1)
        [NoScaleOffset] _MainTex ("Texture", 2D) = "white" {}
        Vector1_3cd180e912bf4d3d88d1662f71f1ca09 ("Saturation", Range(0, 1)) = 1
        Vector1_53d60e90832b406f8ea4b4d5b4c1217c ("Brightness", Range(0, 1)) = 1
        [HideInInspector] _QueueOffset ("_QueueOffset", Float) = 0
        [HideInInspector] _QueueControl ("_QueueControl", Float) = -1
        [HideInInspector] [NoScaleOffset] unity_Lightmaps ("unity_Lightmaps", 2DArray) = "" {}
        [HideInInspector] [NoScaleOffset] unity_LightmapsInd ("unity_LightmapsInd", 2DArray) = "" {}
        [HideInInspector] [NoScaleOffset] unity_ShadowMasks ("unity_ShadowMasks", 2DArray) = "" {}
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
    Fallback "Hidden/Shader Graph/FallbackError"
    //CustomEditor "UnityEditor.ShaderGraph.GenericShaderGraphMaterialGUI"
}