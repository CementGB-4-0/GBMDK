Shader "GangBeasts/Effects/MeatSlime"
{
    Properties
    {
        _BaseColor ("Base Color", Vector) = (0.4811321,0.4811321,0.4811321,0)
        _EmissiveIntensity ("Emission", Range(0, 8)) = 0
        _Wave1Dir ("Wave 1 Direction", Vector) = (0,0,1,0)
        _Wave2Dir ("Wave 2 Direction", Vector) = (1,0,0,0)
        _Waev3Dir ("Wave 3 Direction", Vector) = (-1,0,0,0)
        _Frequency ("Wave Frequency", Float) = 3
        _WaveSpeed ("Wave Speed", Float) = 1.5
        _WaveHeight ("Wave Height", Float) = 1
        [NoScaleOffset] [Normal] _BumpMap ("Normal Map", 2D) = "bump" {}
        _NormalsDir ("Normals Direction 1(XY) & 2(ZW)", Vector) = (0,1,0,0.3333333)
        _Specular ("Specular Color", Vector) = (0.254902,0.1960784,0.2156863,1)
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