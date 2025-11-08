Shader "Shader Graphs/StarShader"
{
    Properties
    {
        Vector1_f449c87e08c04177b8fee1d3ba86635a ("Smoothness", Range(0, 1)) = 0.5
        Vector1_2ce8f9ffaa8c4a7d84474ece322c76c9 ("AmbientOcclusion", Float) = 0
        [NoScaleOffset] Texture2D_bbbd4fa627594001ba0daffe2f46e83e ("Albedo", 2D) = "white" {}
        Vector1_aebe95d948c241448f034d1991778af5 ("NormalStrength", Float) = 0
        Color_004fb45b57de4aaf8eda233268d353d3 ("BaseColor", Vector) = (0,0,0,0)
        [NoScaleOffset] Texture2D_78cec63836c64254b670b7f530b8e62d ("NormalMap", 2D) = "white" {}
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