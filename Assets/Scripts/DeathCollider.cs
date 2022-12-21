using Unity.Mathematics;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class DeathCollider : MonoBehaviour
{
    public GameObject DeathParticlesPrefab;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (DeathParticlesPrefab != null)
        {
            Vector3 particlePosition = collision.transform.position + new Vector3(0, 0.2f, 0);
            Instantiate(DeathParticlesPrefab, particlePosition, quaternion.identity);
        }
        
        PlayerController player = collision.gameObject.GetComponentInParent<PlayerController>();
        player.Respawn();
    }
}
