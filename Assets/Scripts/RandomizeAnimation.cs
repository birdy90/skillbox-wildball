using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Animator))]
public class RandomizeAnimation : MonoBehaviour
{
    public Animator Animator;
    
    private readonly List<string> _triggers = new List<string>
    {
        "Jump",
        "Rotate",
        "Tremble"
    };

    private void Awake()
    {
        if (!Animator) Animator = GetComponent<Animator>();
    }

    public void ChooseRandomAnimation()
    {
        _triggers.ForEach(triggerName => Animator.ResetTrigger(triggerName));
        string randomTrigger = _triggers[Random.Range(0, _triggers.Count)];
        Animator.SetTrigger(randomTrigger);
    }
}
