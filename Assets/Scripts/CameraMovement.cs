using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform Target;
    public Vector3 Offset;
    public float AppliedForceMultiplier;
    public Transform LookAtIndicator;

    private Rigidbody _targetRigidbody;

    private void Awake()
    {
        _targetRigidbody = Target.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        
        Transform cameraTransform = transform;
        Vector3 cameraPosition = cameraTransform.position;
        Vector3 targetPosition = Target.position;
        Vector3 targetVelocity = _targetRigidbody.velocity;

        Vector3 newCameraPosition = targetPosition + Offset;
        Vector3 newLookPosition =
            targetPosition + new Vector3(targetVelocity.x, 0f, targetVelocity.z) * AppliedForceMultiplier;
        
        cameraTransform.position = Vector3.Lerp(cameraPosition, newCameraPosition, 0.1f);
        cameraTransform.LookAt(Vector3.Lerp(targetPosition, newLookPosition, 0.02f));

        LookAtIndicator.position = Vector3.Lerp(targetPosition, newLookPosition, 0.02f);
    }
}