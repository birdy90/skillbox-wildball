using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelsList : MonoBehaviour
{
    public List<SceneAsset> LevelScenes = new List<SceneAsset>();
    
    public GameObject LevelButtonPrefab;
    
    void Start()
    {
        for (int i = 0; i < LevelScenes.Count; i++)
        {
            SceneAsset scene = LevelScenes[i];
            int levelNumber = i + 1;
            GameObject button = Instantiate(LevelButtonPrefab, transform);
            TextMeshProUGUI text = button.GetComponentInChildren<TextMeshProUGUI>();
            text.text = levelNumber.ToString();
            button.GetComponent<Button>().onClick.AddListener(() =>
            {
                PlayerPrefs.SetInt("CurrentLevel", levelNumber);
                SceneManager.LoadScene(scene.name);
            });
        }
    }
}
