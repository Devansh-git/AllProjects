using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LM : MonoBehaviour
{
    public float speed = 10;
    public float lm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
      float lm;

      lm = Input.GetAxis("PaddleLeft");
      
        Rigidbody2D rbody= GetComponent<Rigidbody2D>();
        rbody.velocity = new Vector2(0 * speed, lm * speed);
    }

  

}
