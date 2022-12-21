using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeAnimationShift : MonoBehaviour
{
    public float StabOffset = 0f;
    
    private Animator _animation;

    void Awake()
    {
        GetComponent<Animator>().SetFloat("StabOffset", StabOffset);
    }
}
