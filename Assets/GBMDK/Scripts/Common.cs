#if UNITY_EDITOR

using System.IO;
using UnityEditor;
using UnityEngine;

namespace GBMDK.Editor
{
    public static class Common
    {
        // vibe coded. im tired boss
        /// <summary>
        /// Converts a full absolute path to a Unity project-relative path (e.g., "Assets/...", "Packages/...", or "Library/...").
        /// </summary>
        /// <param name="absolutePath">The full path.</param>
        /// <returns>The Unity path using forward slashes, or the original absolute path if conversion fails.</returns>
        public static string FullPathToUnityPath(string assetsPath, string absolutePath)
        {
            // 1. Normalize path separators to forward slashes for Unity compatibility
            absolutePath = absolutePath.Replace('\\', '/');

            // 2. Get the project root path
            // Application.dataPath gives "C:/.../ProjectName/Assets"
            var projectRootPath = Path.GetDirectoryName(assetsPath)?.Replace('\\', '/');

            // 3. Check for paths within the Assets folder
            if (absolutePath.StartsWith(assetsPath))
            {
                // Use FileUtil.GetProjectRelativePath for paths within Assets
                // Note: FileUtil.GetProjectRelativePath requires forward slashes
                return FileUtil.GetLogicalPath(absolutePath);
            }
            // 4. Check for paths within Library or Packages

            if (projectRootPath != null && absolutePath.StartsWith(projectRootPath))
            {
                // Manually make relative by removing the project root path and a potential leading slash
                var relativePath = absolutePath[projectRootPath.Length..];
                if (relativePath.StartsWith("/"))
                {
                    relativePath = relativePath[1..];
                }
                return relativePath;
            }

            // 5. If it's an external path (e.g., in a different drive), it might remain absolute or require specific package mapping
            // For paths not directly in the project structure, it is often best to return the path as is or handle with specific logic.
            // For standard Unity use cases (Assets, Library, Packages), the above is sufficient.
            return absolutePath;
        }
        
        public static string GetCurrentSelectedAssetPath()
        {
            var path = AssetDatabase.GetAssetPath(Selection.activeObject);
            if (path == "")
                path = "Assets";
            else if (Path.GetExtension(path) != "")
                path = path.Replace(Path.GetFileName(AssetDatabase.GetAssetPath(Selection.activeObject)), "");

            return path;
        }

        public static T CreateAndSaveScriptableObject<T>() where T : ScriptableObject
        {
            var scriptableObject = ScriptableObject.CreateInstance<T>();
            AssetDatabase.CreateAsset(scriptableObject, GetCurrentSelectedAssetPath() + $"/New {typeof(T)}.asset");
            EditorUtility.SetDirty(scriptableObject);
            Undo.RecordObject(scriptableObject, "CreateAndSaveScriptableObject");
            Selection.activeObject = scriptableObject;

            return scriptableObject;
        }
    }
}

#endif