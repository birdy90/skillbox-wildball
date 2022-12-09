using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator Animator;
    
    private float _lastJumpTime = -100f;
    private readonly float _jumpInterval = 1f;

    void Update()
    {
        if (Time.timeSinceLevelLoad - _lastJumpTime > _jumpInterval)
        {
            _lastJumpTime = Time.timeSinceLevelLoad;
            Animator.SetTrigger("Jump");
        }
    }
}
