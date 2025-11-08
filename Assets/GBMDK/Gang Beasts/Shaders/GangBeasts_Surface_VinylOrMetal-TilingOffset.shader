Shader "GangBeasts/Surface/VinylOrMetal-TilingOffset"
{
    Properties
    {
        _BaseColor ("Base Color", Vector) = (0.5,0.5,0.5,0)
        [NoScaleOffset] _BaseMap ("Base Map (RGB)", 2D) = "white" {}
        Vector2_0cc7e2872297450e88cdba7bec667802 ("Base Map Tiling", Vector) = (1,1,0,0)
        Vector2_18e51e7998c24d968d7e9f790adad8d2 ("Base Map Offset", Vector) = (0,0,0,0)
        _BumpScale ("Bump Scale", Float) = 1
        [NoScaleOffset] [Normal] _BumpMap ("Normal Map", 2D) = "bump" {}
        [HDR] _EmissionColor ("Emission Color", Vector) = (0,0,0,0)
        [NoScaleOffset] _EmissionMap ("Emission Map (RGB)", 2D) = "white" {}
        _Metallic ("Metallic", Range(0, 1)) = 0
        [NoScaleOffset] _MetallicMap ("Metallic Map", 2D) = "white" {}
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