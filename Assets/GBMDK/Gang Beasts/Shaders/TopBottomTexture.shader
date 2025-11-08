Shader "Shader Graphs/TopBottomTexture"
{
    Properties
    {
        [NoScaleOffset] Texture2D_c4c83c2dfea74cf99debe2c9a910f7df ("Texture", 2D) = "white" {}
        Color_b1dc77460a494314ac18fb86308674c0 ("Color", Vector) = (1,1,1,0)
        Vector1_3e07756dd9c541c09142dc4db7ced613 ("Power", Range(1, 20)) = 10
        Vector1_c1807fd915f74dd8a4026238d5e248af ("Transition Start", Range(0, 1)) = 0
        Vector1_46cf9ad8eddb4e99881ef51c7712298b ("Transition End", Range(0, 1)) = 1
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