using UnityEngine;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Animator))]
public class RandomizeAnimation : MonoBehaviour
{
    public string RandomizerParameterName = "RandomChooser";
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        ChooseRandomAnimation();
    }

    public void ChooseRandomAnimation()
    {
        int randomAnimationIndex = Random.Range(0, 4);
        if (_animator.GetInteger(RandomizerParameterName) < 0) return;
        _animator.SetInteger(RandomizerParameterName, randomAnimationIndex);
    }
}
