using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "Levels", menuName = "Scriptable Objects/Levels list")]
public class LevelsList : ScriptableObject
{
    public List<Object> Levels;

    public static int CurrentSceneIndex => PlayerPrefs.GetInt("SceneIndex");

    private bool IsLastlevel => CurrentSceneIndex == Levels.Count;
    
    public void LoadNextScene()
    {
        if (!IsLastlevel)
        {
            PlayerPrefs.SetInt("SceneIndex", CurrentSceneIndex + 1);
            SceneManager.LoadScene(LevelsListLoader.GetSceneName(CurrentSceneIndex));
        } 
    }
}
