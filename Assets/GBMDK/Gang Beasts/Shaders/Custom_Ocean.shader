Shader "Custom/Ocean"
{
    Properties
    {
        _TextureFoam ("Texture Ocean Foam", 2D) = "black" {}
        _WaterNormal ("Water Normal 3", 2D) = "black" {}
        _ColorBase ("Base Water Color", Vector) = (0.286,0.551,0.533,1)
        _SeaColor ("Refracted Color", Vector) = (0.286,0.551,0.533,1)
        _FoamColor ("Edge Color", Vector) = (0.286,0.551,0.533,1)
        _SpecColor ("Spec Color", Vector) = (0.286,0.551,0.533,1)
        _WaveShape ("Peakiness, Peakiness scale, Wavelength, Wavelength scale", Vector) = (0.05,0.78,2.37,0.66)
        _WaveSettings ("Steepness, Speed, Seed, Octaves", Vector) = (0.2,0.35,524,7)
        _lightDir ("Light Position (xyz)", Vector) = (1.41,-0.14,3.86,50)
        _LightSettings ("Light Intensity, Light Brightness, Fresnel power, Fresnel mul", Vector) = (70,0.62,0.06,0.9)
        _ColorSettings ("Diffuse Brightness, Diffuse, Diffuse Pow, Color Pow", Vector) = (0.37,0.82,5.2,1.5)
        _NormalMapSettings ("Normal Map Mul (XYZ)", Vector) = (2,0.01,0.08,0.08)
        _DepthSettings ("Depth Settings (Foam Edge Length, Foam Intensity, Foam Cutoff, Translucency)", Vector) = (2,1.5,0.7,9.6)
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