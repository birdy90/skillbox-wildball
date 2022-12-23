using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class CollectibleScript : MonoBehaviour
{
    public ParticleSystem SuccessParticles;
    public GameObject CoinMeshObject;

    public void OnTriggerEnter(Collider collision)
    {
        if (SuccessParticles != null)
        {
            SuccessParticles.Play();
        }
        Destroy(CoinMeshObject);
        StartCoroutine(DestroyCollectible());
    }

    IEnumerator DestroyCollectible()
    {
        yield return new WaitForSecondsRealtime(2f);
        Destroy(gameObject);
    }
}
