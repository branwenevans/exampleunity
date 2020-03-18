#if (UNITY_CLOUD_BUILD)
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CiBuild : MonoBehaviour
{
    public static void PreExport(UnityEngine.CloudBuild.BuildManifestObject manifest)
    {
        int buildNumber = manifest.GetValue<int>("buildNumber");
        Debug.Log("****************BuildNumber");
        Debug.Log(buildNumber);
        int major = 1;
        int minor = 2;
        PlayerSettings.bundleVersion = $"{major}.{minor}.{buildNumber}";
        #if UNITY_ANDROID
            Debug.Log("****************Android");
            PlayerSettings.Android.bundleVersionCode = buildNumber;
        #endif
        EditorPrefs.SetBool("CacheServerEnabled", true);
        EditorPrefs.SetString("CacheServerIPAddress", "34.245.64.200");
        EditorPrefs.SetString("CacheServerMode", "remote");
        Debug.Log("****************SAVING");
        AssetDatabase.SaveAssets();
    }
}
#endif