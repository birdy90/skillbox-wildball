using UnityEngine;

public class PositionTracker : MonoBehaviour
{
    public Transform TargetTransform;
    
    void Update()
    {
        Transform currentTransform = transform;
        Vector3 targetPosition = TargetTransform.position;
        currentTransform.position = new Vector3(targetPosition.x, currentTransform.position.y, targetPosition.z);
    }
}
