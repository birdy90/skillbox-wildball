using UnityEngine;

public class PositionTracker : MonoBehaviour
{
    public Transform TargetTransform;

    private Vector3 _positionShift;

    void Awake()
    {
        _positionShift = transform.position - TargetTransform.position;
    }
    
    void Update()
    {
        Transform currentTransform = transform;
        Vector3 targetPosition = TargetTransform.position + _positionShift;
        currentTransform.position = targetPosition;
    }
}
