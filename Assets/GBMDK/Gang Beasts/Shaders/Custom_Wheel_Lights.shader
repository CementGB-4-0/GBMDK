Shader "Custom/Wheel_Lights"
{
    Properties
    {
        _Color_2 ("Color_2", Vector) = (1,0.6545638,0.03676468,1)
        _Speed_1 ("Speed_1", Float) = 1
        _R_On ("R_On", Float) = 1
        _G_On ("G_On", Float) = 1
        _B_On ("B_On", Float) = 1
        _Alpha ("Alpha", Float) = 0.5
        _Emissive_Boost ("Emissive_Boost", Float) = 1
        _Texture_1 ("Texture_1", 2D) = "white" {}
        _Speed_2 ("Speed_2", Float) = 1
        _Speed_3 ("Speed_3", Float) = 1
        _Color_1 ("Color_1", 2D) = "white" {}
        [HideInInspector] _Cutoff ("Alpha cutoff", Range(0, 1)) = 0.5
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
    Fallback "Diffuse"
    //CustomEditor "ShaderForgeMaterialInspector"
}