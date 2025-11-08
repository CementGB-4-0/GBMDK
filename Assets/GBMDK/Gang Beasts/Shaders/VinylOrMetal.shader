Shader "GangBeasts/Surface/VinylOrMetal"
{
    Properties
    {
        _BaseColor ("Base Color", Vector) = (1,1,1,0)
        [NoScaleOffset] _BaseMap ("Base Map (RGB)", 2D) = "white" {}
        Vector2_0cc7e2872297450e88cdba7bec667802 ("Base Map Tiling", Vector) = (1,1,0,0)
        Vector2_548d1e46deb54e63a95a3c904e1285a2 ("Base Map Offset", Vector) = (0,0,0,0)
        [ToggleUI] Boolean_53813866627c4202933cbfd81bb5ac80 ("Use Vertex Colors", Float) = 0
        _BumpScale ("Bump Scale", Float) = 1
        [NoScaleOffset] [Normal] _BumpMap ("Normal Map", 2D) = "bump" {}
        Vector2_6e77f4833d7d4468b553e075d1c97eca ("Normal Map Tiling", Vector) = (1,1,0,0)
        Vector2_e8e7b4d263ac413d836c3db50597fe12 ("Normal Map Offset", Vector) = (0,0,0,0)
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