using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "Levels", menuName = "Scriptable Objects/Levels list")]
public class LevelsList : ScriptableObject
{
    public List<SceneAsset> Levels;
}
