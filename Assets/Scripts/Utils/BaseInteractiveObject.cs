using UnityEngine;

[RequireComponent(typeof(Collider))]
public abstract class BaseInteractiveObject: MonoBehaviour
{
    protected virtual void Activate()
    {
    }

    public bool NeedClickToActivate = false;

    protected bool PlayerInsideCollider = false;
    
    public void Update()
    {
        if (PlayerInsideCollider && Input.GetKeyDown(KeyCode.E))
        {
            Activate();
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        PlayerInsideCollider = true;
        
        if (NeedClickToActivate)
        {
            PlayerController player = collision.gameObject.GetComponentInParent<PlayerController>();
            player.ShowText("E");
        }
        else
        {
            Activate();
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        PlayerInsideCollider = false;
        
        PlayerController player = collision.gameObject.GetComponentInParent<PlayerController>();
        player.HideText();
    }
}