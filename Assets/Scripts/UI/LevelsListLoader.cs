using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelsListLoader : MonoBehaviour
{
    public LevelsList LevelsList;
    
    public GameObject LevelButtonPrefab;

    public static string GetSceneName(int index)
    {
        return $"Level{index}";
    }

    void Start()
    {
        for (int i = 0; i < LevelsList.Levels.Count; i++)
        {
            int levelNumber = i + 1;
            GameObject button = Instantiate(LevelButtonPrefab, transform);
            TextMeshProUGUI text = button.GetComponentInChildren<TextMeshProUGUI>();
            text.text = levelNumber.ToString();
            button.GetComponent<Button>().onClick.AddListener(() =>
            {
                PlayerPrefs.SetInt("SceneIndex", levelNumber);
                SceneManager.LoadScene(GetSceneName(levelNumber));
            });
        }
        
        Canvas.ForceUpdateCanvases();
        LayoutRebuilder.MarkLayoutForRebuild(GetComponent<RectTransform>());
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
