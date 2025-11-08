Shader "Oculus/OVRMRCameraFrame"
{
    Properties
    {
        _Color ("Main Color", Vector) = (1,1,1,1)
        _MainTex ("Main Texture", 2D) = "white" {}
        _Visible ("Visible", Range(0, 1)) = 1
        _ChromaAlphaCutoff ("ChromaAlphaCutoff", Range(0, 1)) = 0.01
        _ChromaToleranceA ("ChromaToleranceA", Range(0, 50)) = 20
        _ChromaToleranceB ("ChromaToleranceB", Range(0, 50)) = 15
        _ChromaShadows ("ChromaShadows", Range(0, 1)) = 0.02
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
}