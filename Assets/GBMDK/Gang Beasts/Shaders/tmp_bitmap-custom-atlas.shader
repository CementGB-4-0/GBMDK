Shader "TextMeshPro/Bitmap Custom Atlas"
{
    Properties
    {
        _MainTex ("Font Atlas", 2D) = "white" {}
        _FaceTex ("Font Texture", 2D) = "white" {}
        _FaceColor ("Text Color", Vector) = (1,1,1,1)
        _VertexOffsetX ("Vertex OffsetX", Float) = 0
        _VertexOffsetY ("Vertex OffsetY", Float) = 0
        _MaskSoftnessX ("Mask SoftnessX", Float) = 0
        _MaskSoftnessY ("Mask SoftnessY", Float) = 0
        _ClipRect ("Clip Rect", Vector) = (-32767,-32767,32767,32767)
        _Padding ("Padding", Float) = 0
        _StencilComp ("Stencil Comparison", Float) = 8
        _Stencil ("Stencil ID", Float) = 0
        _StencilOp ("Stencil Operation", Float) = 0
        _StencilWriteMask ("Stencil Write Mask", Float) = 255
        _StencilReadMask ("Stencil Read Mask", Float) = 255
        _CullMode ("Cull Mode", Float) = 0
        _ColorMask ("Color Mask", Float) = 15
    }
    //DummyShaderTextExporter
    SubShader
    {
        Tags
        {
            "RenderType"="Opaque" "RenderPipeline"="UniversalPipeline"
        }
        LOD 200

        Pass
        {
            HLSLPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            float4 _MainTex_ST;

            struct Vertex_Stage_Input
            {
                float4 pos : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct Vertex_Stage_Output
            {
                float2 uv : TEXCOORD0;
                float4 pos : SV_POSITION;
            };

            Vertex_Stage_Output vert(Vertex_Stage_Input input)
            {
                Vertex_Stage_Output output;
                output.uv = (input.uv.xy * _MainTex_ST.xy) + _MainTex_ST.zw;
                output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
                return output;
            }

            Texture2D<float4> _MainTex;
            SamplerState sampler_MainTex;

            struct Fragment_Stage_Input
            {
                float2 uv : TEXCOORD0;
            };

            float4 frag(Fragment_Stage_Input input) : SV_TARGET
            {
                return _MainTex.Sample(sampler_MainTex, input.uv.xy);
            }
            ENDHLSL
        }
    }
    //CustomEditor "TMPro.EditorUtilities.TMP_BitmapShaderGUI"
}