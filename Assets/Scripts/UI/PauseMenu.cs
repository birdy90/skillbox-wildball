using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public Animator Animator;
    public SceneAsset MainMenuScene;
    
    private static readonly int IsOpen = Animator.StringToHash("IsOpen");

    public void OnMenuOpen()
    {
        Animator.SetBool(IsOpen, true);
    }
    
    public void OnMenuClose()
    {
        Animator.SetBool(IsOpen, false);
    }

    public void OnRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnGoToMainMenu()
    {
        SceneManager.LoadScene(MainMenuScene.name);
    }
}
