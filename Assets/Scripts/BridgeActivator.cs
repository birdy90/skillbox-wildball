using System.Collections.Generic;
using UnityEngine;

public class BridgeActivator: BaseInteractiveObject
{
    public List<GameObject> BridgeTiles = new List<GameObject>();

    private const string RandomChooser = "RandomChooser";
    private const string StabilizerToggle = "StabilizerToggle";

    protected override void Activate()
    {
        foreach (GameObject tile in BridgeTiles)
        {
            Animator animator = tile.GetComponent<Animator>();
            animator.SetTrigger(StabilizerToggle);
            animator.SetInteger(RandomChooser, -1);
        }
    }
}