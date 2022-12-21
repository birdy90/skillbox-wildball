using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelsListLoader : MonoBehaviour
{
    public LevelsList LevelsList;
    
    public GameObject LevelButtonPrefab;

    void Start()
    {
        for (int i = 0; i < LevelsList.Levels.Count; i++)
        {
            SceneAsset scene = LevelsList.Levels[i];
            int levelNumber = i + 1;
            GameObject button = Instantiate(LevelButtonPrefab, transform);
            TextMeshProUGUI text = button.GetComponentInChildren<TextMeshProUGUI>();
            text.text = levelNumber.ToString();
            button.GetComponent<Button>().onClick.AddListener(() =>
            {
                SceneManager.LoadScene(scene.name);
            });
        }
        
        Canvas.ForceUpdateCanvases();
        LayoutRebuilder.MarkLayoutForRebuild(GetComponent<RectTransform>());
    }
}
