using UnityEngine;

public class MovingPlatformActivator : BaseInteractiveObject
{
    public GameObject ObjectToMove;

    public Vector3 From;
    public Vector3 To;
    public float Speed = 1f;

    private int _directionSign = 1;

    private Vector3 CurrentDestination => _directionSign < 0 ? From : To;
    
    void Awake()
    {
        NeedClickToActivate = false;
    }

    void Update()
    {
        if (!ObjectToMove || !PlayerInsideCollider) return;

        Vector3 currentposition = ObjectToMove.transform.position;
        if ((CurrentDestination - currentposition).magnitude < Mathf.Epsilon)
        {
            _directionSign *= -1;
        }

        ObjectToMove.transform.position =
            Vector3.MoveTowards(currentposition, CurrentDestination, Speed * Time.deltaTime);
    }
}
