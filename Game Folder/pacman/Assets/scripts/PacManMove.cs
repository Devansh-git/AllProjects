using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacManMove : MonoBehaviour
{

    public float speed = 10;
    private Vector2 direction;
    Rigidbody2D rbody;

    


    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") < -0.2)
        {
            direction = Vector2.left;
        }
        if (Input.GetAxis("Horizontal") > 0.2)
        {
            direction = Vector2.right;
        }
        if (Input.GetAxis("Vertical") < -0.2)
        {
            direction = Vector2.down;
        }
        if (Input.GetAxis("Vertical") > 0.2)
        {
            direction = Vector2.up;
        }

        rbody.velocity = direction * speed;
        transform.right = direction;
    }
}
