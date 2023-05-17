using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUp : PickUp
{
    public float healValue; //How much the pickup heals

    public override void Activate()
    {
        player.health += healValue;
        if(player.health > player.maxhealth)
        {
            player.health = player.maxhealth;
        }
    }
}
