using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.tag == "Block")
        {

           
            DestroyObject(Collision.gameObject);
            Destroy(gameObject);
            


        }

    }
}