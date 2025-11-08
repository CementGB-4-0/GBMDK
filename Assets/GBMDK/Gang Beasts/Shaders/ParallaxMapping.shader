Shader "Custom/ParallaxMapping"
{
    Properties
    {
        _DiffuseTex ("Diffuse Tex", 2D) = "white" {}
        _NormalMap ("Normal Map", 2D) = "white" {}
        _HeightMap ("Height Map", 2D) = "white" {}
        _WindowTex ("Window", 2D) = "white" {}
        _HeightScale ("Bump Scale", Float) = 0.2
        _lightDir ("light pos", Vector) = (0,0,0,0)
        _BaseCol ("Base Color", Vector) = (0,0,0,0)
        _RimCol ("Fresnel Color", Vector) = (0,0,0,0)
        _SpecCol ("Specular Color", Vector) = (0,0,0,0)
        _LightSettings ("Fresnel Power, Specular Power, Specular Intenisty, Minimum Light", Vector) = (-2,1.64,0.4,0)
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
}