using UnityEngine;

public class InputController : MonoBehaviour
{
    public PlayerController PlayerController;

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        var verticalInput = Input.GetAxis(Constants.VerticalAxis);
        var horizontalInput = Input.GetAxis(Constants.HorizontalAxis);
        var appliedForce = new Vector3(horizontalInput, 0, verticalInput);
        PlayerController.MoveDirection(appliedForce.normalized);
    }
}