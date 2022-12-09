using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelInfo : MonoBehaviour
{
    void Start()
    {
        var levelNumber = PlayerPrefs.GetInt("CurrentLevel", 0);
        var text = GetComponentInChildren<TextMeshProUGUI>();
        text.text = $"Level {levelNumber}";
    }
}
