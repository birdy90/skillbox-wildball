using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelInfo : MonoBehaviour
{
    public LevelsList LevelsList;
    
    void Start()
    {
        int levelNumber = LevelsList.CurrentSceneIndex;
        TextMeshProUGUI text = GetComponentInChildren<TextMeshProUGUI>();
        text.text = $"Level {levelNumber}";
    }
}
