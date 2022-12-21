using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelInfo : MonoBehaviour
{
    public LevelsList LevelsList;
    
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        int levelNumber = LevelsList.Levels.FindIndex(scene => currentScene.name == scene.name) + 1;
        TextMeshProUGUI text = GetComponentInChildren<TextMeshProUGUI>();
        text.text = $"Level {levelNumber}";
    }
}
