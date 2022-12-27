using System;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class RespawnPoint : MonoBehaviour
{
    public ParticleSystem ParticlesForActivation;

    /// <summary>
    /// Update respawn point and play particles if point was updated
    /// </summary>
    /// <param name="other"></param>
    public void OnTriggerEnter(Collider other)
    {
        PlayerController player = other.gameObject.GetComponentInParent<PlayerController>();

        if (player.UpdateRespawnPoint(transform.position))
        {
            ParticlesForActivation.Play();
        }
    }
}
