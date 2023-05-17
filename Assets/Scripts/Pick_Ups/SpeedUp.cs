using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : PickUp
{
    public override void Activate()
    {
        player.moveSpeed++;
    }
}
