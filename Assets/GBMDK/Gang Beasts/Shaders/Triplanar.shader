Shader "Shader Graphs/Triplanar"
{
    Properties
    {
        Vector1_96A950D7 ("Texture power", Range(0, 20)) = 10
        [NoScaleOffset] Texture2D_E003BD79 ("BaseMap", 2D) = "white" {}
        Color_275DFC4F ("Base Color", Vector) = (1,1,1,1)
        Vector1_A00E5024 ("Metallic", Range(0, 1)) = 0
        Vector1_8E27584D ("Smoothness", Range(0, 1)) = 0.4
        Vector1_4F62D76F ("Tiling", Float) = 1
        Vector2_41600EDC ("Offset", Vector) = (0,0,0,0)
        [NoScaleOffset] [Normal] Texture2D_459C7B2F ("NormalMap", 2D) = "bump" {}
        Vector1_A8BE3050 ("Normal Map Strength", Float) = 1
        [NoScaleOffset] [Normal] Texture2D_4B06A00B ("Detail NormalMap", 2D) = "bump" {}
        Vector1_68A68CDD ("Detail Tiling", Float) = 1
        Vector1_73A5D377 ("Detail Map Strength", Float) = 1
        [HideInInspector] _QueueOffset ("_QueueOffset", Float) = 0
        [HideInInspector] _QueueControl ("_QueueControl", Float) = -1
        [HideInInspector] [NoScaleOffset] unity_Lightmaps ("unity_Lightmaps", 2DArray) = "" {}
        [HideInInspector] [NoScaleOffset] unity_LightmapsInd ("unity_LightmapsInd", 2DArray) = "" {}
        [HideInInspector] [NoScaleOffset] unity_ShadowMasks ("unity_ShadowMasks", 2DArray) = "" {}
        [Toggle] BOOLEAN_99D947FD ("Triplanar local space", Float) = 0
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