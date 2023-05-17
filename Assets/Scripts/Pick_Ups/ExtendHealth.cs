using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtendHealth : HealthPickUp
{
    public override void Activate()
    {
        player.maxhealth = player.maxhealth + 10;
    }
}
