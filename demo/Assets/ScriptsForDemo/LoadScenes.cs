using UnityEngine;
using System.Collections;

public class LoadScenes : BaseLoader {

	public string sceneAssetBundle = "scene.unity3d";
	public string sceneName = "testScene";
    public string[] variants = new string[]{"td"};

	public bool loadLevelAdditive = true;

	// Use this for initialization
	IEnumerator Start () {
		
		yield return StartCoroutine(Initialize() );

        AssetBundleManager.Variants = variants;

		// Load level.
		yield return StartCoroutine(LoadLevel (sceneAssetBundle, sceneName, loadLevelAdditive) );

		// Unload assetBundles.
		AssetBundleManager.UnloadAssetBundle(sceneAssetBundle);
	}
}
