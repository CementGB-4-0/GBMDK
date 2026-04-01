using System;
using System.Collections.Generic;
using UnityEngine;

namespace CS.CorePlatform.Utils.Data
{
    public class PlatformStorageDatabase : ScriptableObject, ISerializationCallbackReceiver
    {
        [SerializeField] public OculusStorageInfo Oculus;

        [SerializeField] public XboxStorageInfo Xbox;

        [SerializeField] public NintendoStorageInfo Nintendo;

        [SerializeField] public NoneStorageInfo None;

        [SerializeField] public List<string> saveLocalFiles;

        [SerializeField] public List<string> saveCloudFiles;

        [NonSerialized] public List<string> allFiles;

        public void OnBeforeSerialize()
        {
        }

        public void OnAfterDeserialize()
        {
        }

        [Serializable]
        public class OculusStorageInfo
        {
            public string bucketName;
        }

        [Serializable]
        public class XboxStorageInfo
        {
            public string containerName;
        }

        [Serializable]
        public class NintendoStorageInfo
        {
            public string MountName;
        }

        [Serializable]
        public class NoneStorageInfo
        {
            public string directory;
        }
    }
}