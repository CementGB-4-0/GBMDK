Shader "Unlit/VolumeLight"
{
    Properties
    {
        [HDR] _Color ("Color", Vector) = (1,1,1,0)
        _Flicker ("Flicker Intensity", Range(0, 1)) = 1
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
}