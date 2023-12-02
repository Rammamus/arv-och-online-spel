using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerAttack : MonoBehaviour
{
    public GameObject slash;
    float attackTimer = 0;
    float attackCooldown = 1;
    bool canAttack;
    PhotonView view;
    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();

    }

    // Update is called once per frame
    void Update()
    {
        if (view.IsMine)
        {
            Attack();
        }
    }

    public void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && canAttack)
        {
            slash.transform.position += new Vector3(0, 0, 1.2f);
            slash.transform.Rotate(90, 0, 0);
            attackTimer = 0;
            canAttack = false;
        }

        if (!canAttack)
        {
            attackTimer += Time.deltaTime;
        }
    }

    void ResetSlash()
    {

    }
}
