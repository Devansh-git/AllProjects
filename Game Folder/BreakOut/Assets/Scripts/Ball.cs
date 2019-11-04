using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{


    public float speed = 5f;

    private Rigidbody2D ball;

    public GameObject powerup1pellet;

    public Transform powerup1pelletlocation;

    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody2D>();

        ball.velocity = new Vector2(0f, speed);
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.position.y < -5)
        {
            ball.position = new Vector2(0f, -3.90f);
            ball.velocity = new Vector2(0f, speed);
        }

        

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
       
        if(collision.gameObject.name=="Block")
        {
            DestroyObject(collision.gameObject);
        }
        
        if(collision.gameObject.name=="Block(powerup1)")
        {
            DestroyObject(collision.gameObject);
            Instantiate(powerup1pellet, powerup1pelletlocation.transform.position, powerup1pellet.transform.rotation);

        }

       
        if(collision.gameObject.name=="p2")
        {
            DestroyObject(collision.gameObject);

        }


        float bounce = ball.transform.position.x - GameObject.Find("Player").transform.position.x;
        if (collision.gameObject.name == "Player")
        {
            ball.velocity = new Vector2(bounce*2f,speed );
        }

    }

}
