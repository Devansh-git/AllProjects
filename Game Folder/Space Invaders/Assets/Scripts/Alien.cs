using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{


    public float speed = 0.4f;
    
    // Minimum time to wait before firing
    public float minFireRateTime = 1.0f;

    //public GameObject AlienBullet;
    
    // Maximum time to wait before firing
    public float maxFireRateTime = 6.0f;

    // Base firing wait time
    public float baseFireWaitTime = 6.0f;

    public float MoveRate = 2.0f;
    private float counter = 0.0f;

    private Rigidbody2D rbody;




    // Start is called before the first frame update
    void Start()
    {

        rbody = GetComponent<Rigidbody2D>();

        rbody.velocity = new Vector2(1 * speed, 0);
    }

    // Update is called once per frame
    void Update()
    {


    }

    void Turn(int direction)
    {
        Vector2 newVelocity = rbody.velocity;
        newVelocity.x = speed * direction;
        rbody.velocity = newVelocity;
    }

    void MoveDown()
    {
        Vector2 position = transform.position;
        position.y -= 1;
        transform.position = position;
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.name == "WL")
        {
            Turn(1);
            MoveDown();
        }
        if (col.gameObject.name == "WR")
        {
            Turn(-1);
            MoveDown();
        }




    }

   // void FixedUpdate()
    //{

        //if (Time.time > baseFireWaitTime)
        //{

            //baseFireWaitTime = baseFireWaitTime +
              //  Random.Range(minFireRateTime, maxFireRateTime);

           // Instantiate(AlienBullet, transform.position, Quaternion.identity);

       // }


   //}

}