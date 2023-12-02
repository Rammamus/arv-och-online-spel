using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : PowerUps
{
    public PlayerMovement pm;
    int startingjmpforce;
    // Start is called before the first frame update
    void Start()
    {
        startingjmpforce = pm.jumpForce;
    }

    public override void ActivatePower()
    {
        print(pm.jumpForce);
        pm.jumpForce = 1000;
    }

    public override void DeactivatePower()
    {
        pm.jumpForce = startingjmpforce;
        print(pm.jumpForce);
        base.DeactivatePower();
    }
}
