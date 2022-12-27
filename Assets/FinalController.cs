using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Component to do all the work after player finished the game
/// </summary>
[RequireComponent(typeof(Collider))]
public class FinalController : MonoBehaviour
{
    public ParticleSystem FireworkParticles;
    public PauseMenu Menu;
    public Button PlayButton;
    public Button RestartButton;
    public GameObject FinishPanel;
    public Vector3 NewCameraOffset;

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(FireworkParticles, transform);
        Menu.OnMenuOpen();
        PlayButton.interactable = false;
        RestartButton.interactable = false;
        FinishPanel.SetActive(true);
        
        // to see the fireworks we need to change camera angle
        CameraMovement playerCamera = collision.transform.parent.GetComponentInChildren<CameraMovement>();
        playerCamera.Offset = NewCameraOffset;
    }
}
