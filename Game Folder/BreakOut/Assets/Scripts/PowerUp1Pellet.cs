using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp1Pellet : MonoBehaviour
{
    public GameObject powerup1;

    public GameObject loc;
    
  void OnTriggerEnter2D(Collider2D Collision)
    {
        if(Collision.tag=="Player")
        {
            Destroy(gameObject);
            Instantiate(powerup1,loc.transform.position,powerup1.transform.rotation);

        }
    }
}
