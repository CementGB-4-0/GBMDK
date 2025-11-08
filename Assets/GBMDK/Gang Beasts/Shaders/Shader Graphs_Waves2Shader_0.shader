Shader "Shader Graphs/Waves2Shader"
{
    Properties
    {
        _WaveHeight ("WaveHeight", Float) = 1
        _WaveDistance ("WaveDistance", Float) = 0
        _WaveDirection ("WaveDirection", Vector) = (1,1,1,1)
        _WaveSteepness ("WaveSteepness", Float) = 1
        _WaveCount ("WaveCount", Range(0, 5)) = 5
        Vector1_6a24e037849d4142917d493166e03965 ("Depth", Float) = 1
        [HDR] Color_4dccd8b907ea47d3b1e70f48a4d14021 ("ShallowColour", Vector) = (0,0.9329295,1,0)
        [HDR] Color_6cbf487b290e4742afeb277623974bfb ("DeepColour", Vector) = (0.1494304,0.4220921,0.4339623,0)
        Vector1_be58c059142b4ffcac1401ba5ec59623 ("WaveTint", Range(-0.1, 0.1)) = 0
        Vector1_86d6a9aa91f6431eab1dab233b325251 ("IntersectionLength", Range(0.01, 10)) = 1
        [NoScaleOffset] Texture2D_1e3ba42cd2304842b17032f6879501f6 ("IntersectionNoise", 2D) = "white" {}
        Vector1_e77dbe299f9d47d1a7dccb9f9a3b4518 ("IntersectionFallloff", Float) = 1
        Vector1_88e50b7b82ef49a69adc97ebbbcf21cb ("IntersectionClip", Float) = 0.1
        Vector1_14816268a3324289b2b6dad285a9d1ec ("IntersectionTiling", Float) = 0
        Color_3b6638a67cfd46a384f088b8eabb3cdb ("InteresectionColour", Vector) = (0,0,0,0)
        Vector1_f71ed962793a48bf9ba6894754ac7107 ("SparkleIntensity", Float) = 1
        Vector1_a95a1c24e2814a3a827e0f665102130b ("SparkleSize", Float) = 0
        [NoScaleOffset] [Normal] Texture2D_7e9864d56ca14718885fccc895dcd93e ("Normal1", 2D) = "bump" {}
        Vector1_3e8f6124fe6f4bbea33a59668333388c ("NormalSpeed", Float) = 1
        Vector1_34f5c07697d64bff9db9846b61538e2b ("NormalStrength", Float) = 0.3
        Vector1_ebf1d630df044151b8bf76fe185dc804 ("FoamWaveMask", Float) = 1
        Vector1_156386f2c9a144cda0608aa58d34ec71 ("FoamWaveMaskExp", Float) = 2.37
        Vector1_adb377daa8d04eff8de4126b2c654d91 ("FoamTiling", Float) = 0.199
        [NoScaleOffset] Texture2D_a726f0c9839741b7af0f4d5f6fe48e9e ("Foam", 2D) = "white" {}
        Vector1_af4619df110843c8b41eb3c8c5e8fb4a ("FoamSize", Float) = 0.01
        [HDR] Color_7bcb0e48f4b7480caab79dae0a641788 ("FoamColor", Vector) = (1,1,1,0)
        Vector1_ea6428143d4149ada30c84c73c21a4ea ("SpecularDistortion", Float) = 1
        Vector1_0d4551f1e4794224a0aa4281d76e2147 ("SpecularSize", Range(0, 1)) = 0
        Vector1_31803adeefaa44f8b80eb5fc9d58d54a ("NormalTiling", Float) = 1
        Vector1_3f7078dec5c14ca68e3c0aecddaeca9b ("SpecularIntensity", Float) = 0
        _CustomTime ("CustomTime", Float) = -1
        Vector1_6ecda9c08ace47159941879ebc35da72 ("Alpha", Float) = 0
        Vector1_1d0c9a5db5d046d1b0971bc2ddb64ccf ("DepthExp", Range(0, 1)) = 0
        Vector1_7711a82445d74b98afb639e41bca2a2b ("DepthT", Range(0, 1)) = 0
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