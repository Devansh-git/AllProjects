using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser2 : MonoBehaviour
{
    private Rigidbody2D rbody;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

        rbody = GetComponent<Rigidbody2D>();
        rbody.velocity = Vector2.down * speed;



    }


    void OnTriggerEnter2D(Collider2D coll)
    {
        // If Bullet hits a wall destroy bullet
        
        if (coll.gameObject.name == "WD")
        {
            Destroy(gameObject);
        }

        if (coll.tag == "Player")
        {
            Destroy(gameObject);

            DestroyObject(coll.gameObject, 0.1f);
        }


    }
}
