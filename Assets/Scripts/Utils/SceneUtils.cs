using UnityEngine.SceneManagement;

public static class SceneUtils
{ 
    public static void LoadNextScene(LevelsList LevelsList)
    {
        Scene currentScene = SceneManager.GetActiveScene();
        int currentIndex = LevelsList.Levels.FindIndex(scene => currentScene.name == scene.name);
        if (currentIndex != LevelsList.Levels.Count - 1)
        {
            SceneManager.LoadScene(LevelsList.Levels[currentIndex + 1].name);
        } 
    }
}