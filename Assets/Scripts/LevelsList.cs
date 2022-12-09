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
        for (var i = 0; i < LevelScenes.Count; i++)
        {
            var scene = LevelScenes[i];
            var levelNumber = i + 1;
            var button = Instantiate(LevelButtonPrefab, transform);
            var text = button.GetComponentInChildren<TextMeshProUGUI>();
            text.text = levelNumber.ToString();
            button.GetComponent<Button>().onClick.AddListener(() =>
            {
                PlayerPrefs.SetInt("CurrentLevel", levelNumber);
                SceneManager.LoadScene(scene.name);
            });
        }
    }
}
