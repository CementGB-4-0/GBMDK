Shader "Shader Graphs/URPVertexOffset"
{
    Properties
    {
        [NoScaleOffset] Texture2D_09f22ba23d644f9e90c1957bc4abaf51 ("Diffuse Tex", 2D) = "white" {}
        Vector2_a558ccd98e934d95a61142dede3d0a5d ("Tiling", Vector) = (1,1,0,0)
        Vector2_4f5acec881314aaeb30426ca18188899 ("Offset", Vector) = (0,0,0,0)
        Color_6146f1e6f1e940a0bc65fb799fc0b0cf ("Diffuse Tint", Vector) = (1,1,1,1)
        [NoScaleOffset] Texture2D_9099e8d3966d4c308f866490f1ae6227 ("Normal Tex", 2D) = "white" {}
        Vector2_95bd4270fa4c479bab9ec9310d868d2d ("Normal Tiling", Vector) = (1,1,0,0)
        Vector2_957477fcf7584d94ba0faef654ed072d ("Normal Offset", Vector) = (0,0,0,0)
        Vector1_cec315b0e98747aab8d694c440d27ed9 ("Normal Intensity", Range(0, 1)) = 1
        Vector3_f711f3b6a52b4a7ab7bb1a498ef48bb2 ("Road: Weight, Curvature, Steepness", Vector) = (0,5,0,0)
        Vector1_5b558fe7a33f40ba95dca71a46d6a323 ("Gloss", Range(0, 1)) = 0
        Vector1_d215667e9b1842729f4a63fc4f93b65e ("Metalic", Float) = 0
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