Shader "Custom/Sludge_Shader"
{
    Properties
    {
        _Color_1 ("Color_1", Vector) = (1,1,1,1)
        _Color_2 ("Color_2", Vector) = (1,0,0,1)
        _Metalic_1 ("Metalic_1", Float) = 0.5
        _Metalic_2 ("Metalic_2", Float) = 0.5
        _Gloss_1 ("Gloss_1", Float) = 0.5
        _Gloss_2 ("Gloss_2", Float) = 0.5
        _Sludge_Hight ("Sludge_Hight", Float) = 1
        _Texture ("Texture", 2D) = "white" {}
        _Noise ("Noise", Float) = 0.2
        _Color_Boost ("Color_Boost", Float) = 0.2
        _Opacity ("Opacity", Float) = 0.9
        _Depth_Blend ("Depth_Blend", Float) = 1
        _Sludge_Color ("Sludge_Color", Vector) = (0.5,0.5,0.5,1)
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