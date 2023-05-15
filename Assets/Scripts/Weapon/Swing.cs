using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : Weapon
{
    //Swinging variables
    public float swingSpeed;
    public float swingDegrees;

    public override void Attack()
    {
        //Rotate to start position
        transform.localEulerAngles = new Vector3(0, 0, -swingDegrees);
        //Active weapon
        EnableWeapon();
        //Swing and deactivate

    }

    //Swinging Coroutine

    IEnumerator Swings()
    {
        float degrees = 0;
        while(degrees < swingDegrees * 2)
        {
            transform.Rotate(Vector3.forward, swingSpeed * Time.deltaTime);
            degrees += swingSpeed * Time.deltaTime;
            yield return new WaitForEndOfFrame();

        }

        DisableWeapon();
    }
}
