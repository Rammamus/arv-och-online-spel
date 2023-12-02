using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssaultRifle : Weapons
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            attkCooldown = 0.2f;
            dmg = 5;
            b.bulletSpeed = 20;
            print("ar");
        }
    }
    
}
