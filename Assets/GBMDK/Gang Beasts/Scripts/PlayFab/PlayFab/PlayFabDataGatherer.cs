using UnityEngine;
using UnityEngine.Rendering;

namespace PlayFab
{
    public class PlayFabDataGatherer
    {
        public string Company;

        public string DataPath;

        public string DeviceModel;

        public DeviceType DeviceType;

        public string DeviceUniqueId;

        public int GraphicsDeviceId;

        public string GraphicsDeviceName;

        public int GraphicsMemorySize;

        public bool GraphicsMultiThreaded;

        public int GraphicsShaderLevel;

        public GraphicsDeviceType GraphicsType;

        public string OperatingSystem;

        public string PersistentDataPath;

        public RuntimePlatform Platform;

        public int ProcessorCount;

        public int ProcessorFrequency;

        public string ProcessorType;

        public string ProductBundle;
        public string ProductName;

        public bool RunInBackground;

        public string StreamingAssetsPath;

        public bool SupportsAccelerometer;

        public bool SupportsGyroscope;

        public bool SupportsLocationService;

        public int SystemMemorySize;

        public int TargetFrameRate;

        public string UnityVersion;

        public string Version;

        public string GenerateReport()
        {
            return null;
        }
    }
}