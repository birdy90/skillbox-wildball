using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator Animator;
    
    private float _lastJumpTime = -100f;
    private float _jumpInterval = 1f;

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad - _lastJumpTime > _jumpInterval)
        {
            _lastJumpTime = Time.timeSinceLevelLoad;
            Animator.SetTrigger("Jump");
        }
    }
}
