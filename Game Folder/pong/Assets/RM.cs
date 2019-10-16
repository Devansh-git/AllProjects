using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RM : MonoBehaviour
{
    public float velocity = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rm;
        rm = Input.GetAxis("PaddleRight");

        Rigidbody2D rBody = GetComponent<Rigidbody2D>();
        rBody.velocity = new Vector2(0, rm * velocity);

    }
}
