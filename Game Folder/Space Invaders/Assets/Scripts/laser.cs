using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    private Rigidbody2D rbody;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

        rbody = GetComponent<Rigidbody2D>();
        rbody.velocity = Vector2.up * speed;



    }


    void OnTriggerEnter2D(Collider2D col)
    {
        // If Bullet hits a wall destroy bullet
        if (col.tag == "Wall")
        {
            Destroy(gameObject);
        }

        if(col.tag=="Alien")
        {
            Destroy(gameObject);

            DestroyObject(col.gameObject, 0.1f);
        }


    }

   


}