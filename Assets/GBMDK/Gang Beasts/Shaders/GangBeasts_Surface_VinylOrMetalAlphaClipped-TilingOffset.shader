Shader "GangBeasts/Surface/VinylOrMetalAlphaClipped-TilingOffset"
{
    Properties
    {
        _BaseColor ("Base Color", Vector) = (0.5,0.5,0.5,0)
        [NoScaleOffset] _BaseMap ("Base Map (RGB)", 2D) = "white" {}
        Vector1_7044c1714c094d7cbf5568a6d8a0a523 ("Alpha Cutoff", Float) = 0.5
        Vector2_02eb3be0ea454fedac7fd687dfbf0c71 ("Base Map Tiling", Vector) = (1,1,0,0)
        Vector2_8d5ada6f915b44aca082e34cd048e1c8 ("Base Map Offset", Vector) = (0,0,0,0)
        _BumpScale ("Bump Scale", Float) = 1
        [NoScaleOffset] [Normal] _BumpMap ("Normal Map", 2D) = "bump" {}
        [HDR] _EmissionColor ("Emission Color", Vector) = (0,0,0,0)
        [NoScaleOffset] _EmissionMap ("Emission Map (RGB)", 2D) = "black" {}
        _Metallic ("Metallic", Range(0, 1)) = 0
        _Smoothness ("Smoothness", Range(0, 1)) = 0.2
        [NoScaleOffset] _MetallicGlossMap ("Gloss Map (A)", 2D) = "white" {}
        [NoScaleOffset] _OcclusionMap ("Occlusion Map (R)", 2D) = "white" {}
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