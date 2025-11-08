Shader "Trucks/Road_Vertex_Offset"
{
    Properties
    {
        _Scale_1 ("Scale_1", Float) = 1
        _Postion ("Postion", Vector) = (0,0,0,0)
        _node_1222 ("node_1222", Float) = 0
        _Color ("Color", Vector) = (0.5,0.5,0.5,1)
        _Metalic ("Metalic", Float) = 1
        _Gloss ("Gloss", Float) = 1
        [MaterialToggle] _Falloff_Gradient ("Falloff_Gradient", Float) = 0
        _Diffuse ("Diffuse", 2D) = "white" {}
        _Falloff_Power ("Falloff_Power", Float) = 2
        _Emissive_Color ("Emissive_Color", Vector) = (0,0,0,1)
        _Emissive_Boost ("Emissive_Boost", Float) = 0
        _Emissive_Texture ("Emissive_Texture", 2D) = "black" {}
        [MaterialToggle] _Use_Emissive_Texture ("Use_Emissive_Texture", Float) = 0
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
                output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
                return output;
            }

            float4 _Color;

            float4 frag(Vertex_Stage_Output input) : SV_TARGET
            {
                return _Color; // RGBA
            }
            ENDHLSL
        }
    }
    Fallback "Diffuse"
    //CustomEditor "ShaderForgeMaterialInspector"
}