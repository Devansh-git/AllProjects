using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{

    public float speed = 20f;
    public Vector2 bottomLeftBoundary;
    public Vector2 topRightBoundary;
    public GameObject Bullet;
    public Transform Spawn;

    public float FireRate = 0.3f;

    //Private Variables
    private Rigidbody2D rbody;
    private float counter = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }


    void Update()
    {

        counter += Time.deltaTime;



        if (Input.GetButton("Fire1") && counter > FireRate)
        {
            //instantiate the laser
            Instantiate(Bullet, Spawn.position, Spawn.transform.rotation);


            counter = 0.0f;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        float m = Input.GetAxis("Horizontal");

        
        rbody.velocity = new Vector2(m * speed, 0);

        //Restrict the player from leaving the play area

        rbody.position = new Vector2(
            Mathf.Clamp(rbody.position.x, bottomLeftBoundary.x, topRightBoundary.x),
            Mathf.Clamp(rbody.position.y, bottomLeftBoundary.y, topRightBoundary.y));



    }
}
