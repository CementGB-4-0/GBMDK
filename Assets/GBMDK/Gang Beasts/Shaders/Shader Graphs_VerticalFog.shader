Shader "Shader Graphs/VerticalFog"
{
    Properties
    {
        Vector1_564e83061724459683c0ac5aa0dfbdf7 ("Start", Range(-10, 10)) = 0
        Vector1_4e0d1043261b4946a449b7dc2e1e78a7 ("End", Range(-10, 10)) = 0
        [HDR] Color_a4590b0b109947728541e6031177ddd9 ("Far Color", Vector) = (0,0,0,0)
        [HDR] Color_66f7d64b853344349238ce60815334f4 ("Mid Color", Vector) = (0.490566,0.490566,0.490566,0)
        [HDR] Color_109607a8bfda4137a52f71b57148b3c5 ("Near Color", Vector) = (0,0,0,0)
        Vector1_8a6c782f3f7d4ea5b1255aa533f8a2fc ("Mid Point", Range(0, 1)) = 0.5
        _FadeDistance ("Fade Distance", Float) = 1
        _FadeSoftness ("Fade Softness", Range(0.01, 2)) = 1
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
            "RenderType" = "Opaque" "RenderPipeline"="UniversalPipeline"
        }
        LOD 200

        Pass
        {
            HLSLPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            struct Vertex_Stage_Input
            {
                float4 pos : POSITION;
            };

            struct Vertex_Stage_Output
            {
                float4 pos : SV_POSITION;
            };

            Vertex_Stage_Output vert(Vertex_Stage_Input input)
            {
                Vertex_Stage_Output output;
                output.pos = TransformObjectToHClip(input.pos.xyz);
                return output;
            }

            float4 frag(Vertex_Stage_Output input) : SV_TARGET
            {
                return float4(1.0, 1.0, 1.0, 1.0); // RGBA
            }
            ENDHLSL
        }
    }
    Fallback "Hidden/Shader Graph/FallbackError"
    //CustomEditor "UnityEditor.ShaderGraph.GenericShaderGraphMaterialGUI"
}