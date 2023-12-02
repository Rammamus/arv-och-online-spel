using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Weapons : MonoBehaviour
{
    public float attkCooldown;
    public float timer = 0;
    public bool canAttk;
    public float dmg;

    [SerializeField] public Bullet b;

    public GameObject player;
    public GameObject bullet;
    public Transform offset;

    PhotonView view;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }

    public void Attack()
    {
        /*if (view.IsMine)
        {
        }*/
        AttackTimer();
        if (Input.GetKeyDown(KeyCode.Mouse0) && canAttk)
        {
            Instantiate(bullet, offset.transform.position, player.transform.rotation);
            canAttk = false;
            timer = 0;
        }
    }

    public void AttackTimer()
    {
        if (!canAttk)
        {
            timer += Time.deltaTime;
            if (timer > attkCooldown)
            {
                canAttk = true;
                timer = 0;
            }
        }
    }
}
