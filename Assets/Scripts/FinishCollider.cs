using UnityEngine;

[RequireComponent(typeof(Collider))]
public class FinishCollider : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        PlayerController player = collision.gameObject.GetComponentInParent<PlayerController>();
        player.SetFinished();
    }
}
