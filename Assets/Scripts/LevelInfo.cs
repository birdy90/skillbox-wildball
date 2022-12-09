using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelInfo : MonoBehaviour
{
    void Start()
    {
        int levelNumber = PlayerPrefs.GetInt("CurrentLevel", 0);
        TextMeshProUGUI text = GetComponentInChildren<TextMeshProUGUI>();
        text.text = $"Level {levelNumber}";
    }
}
