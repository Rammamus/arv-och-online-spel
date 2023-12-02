using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public PlayerMovement pm;
    public Transform orientation;
    public Vector3 moveDirection;
    float horizontalInput;
    float verticalInput;
    public float bulletSpeed;
    float existTimer;

    [SerializeField] Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
        pm = FindFirstObjectByType<PlayerMovement>();
        rb.AddForce(pm.orientation.forward * bulletSpeed * 100);
    }

    // Update is called once per frame
    void Update()
    {
        existTimer += Time.deltaTime;
        if (existTimer > 5)
        {
            Destroy(this.gameObject);
        }
    }
}
