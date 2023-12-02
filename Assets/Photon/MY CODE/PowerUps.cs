using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    [SerializeField]
    float timer;

    bool gamertime = false;

    // Update is called once per frame
    public virtual void Update()
    {
        if (gamertime)
        {
            timer -= Time.deltaTime;
            if (timer > 0)
            {
                ActivatePower();
            }
            else
            {
                DeactivatePower();
            }
        }
    }
    public virtual void ActivatePower()
    {

    }

    public virtual void DeactivatePower()
    {
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gamertime = true;
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;
        }
    }
}
