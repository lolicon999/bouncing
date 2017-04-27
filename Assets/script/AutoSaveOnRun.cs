
#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
[InitializeOnLoad]
public class AutoSaveOnRun: ScriptableObject
{
	static AutoSaveOnRun()
	{
		EditorApplication.playmodeStateChanged = () =>
		{
			if(EditorApplication.isPlayingOrWillChangePlaymode && !EditorApplication.isPlaying)
			{
				Debug.Log("Auto-Saving scene before entering Play mode: " + EditorApplication.currentScene);
				
				EditorApplication.SaveScene();
				AssetDatabase.SaveAssets();
			}
		};
	}
}
#endif