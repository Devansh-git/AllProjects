using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bm : MonoBehaviour
{
    int p1 = 0;
    int p2 = 0;
    public float speed;
    Rigidbody2D ball;
    Collision2D hit;
    public Text scoreboard;
    public Text win;

    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
        int rand = Random.Range(0, 2);

        if (rand == 0)
        {
            ball.velocity = new Vector2(-speed, 0f);
        }
        else if (rand == 1)
        {
            ball.velocity = new Vector2(speed, 0f);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (ball.position.x > 9)
        {
            p1 += 1;
            
            ball.position = new Vector2(0f, 0f);
            ball.velocity = new Vector2(-speed, 0f);
        }
        if (ball.position.x < -9)
        {
            p2 += 1;
            
            ball.position = new Vector2(0f, 0f);
            ball.velocity = new Vector2(speed, 0f);
        }

        string str1 = p1.ToString();
        string str2 = p2.ToString();
        scoreboard.text = str1 + "   -   " + str2;

        if(p1==5||p2==5)
        {
            ball.position = new Vector2(0f, 0f);
            
            ball.velocity = new Vector2(0f,0f);

            if(p1==5)
            {
                win.text = "Player 1 Wins";

            }

            if(p2==5)
            {
                win.text = "Player 2 Wins";
            }

        }


    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        float leftbounce = ball.transform.position.y - GameObject.Find("paddle left").transform.position.y;
        float rightbounce = ball.transform.position.y - GameObject.Find("paddle right").transform.position.y;
        
        if (collision.gameObject.name == "paddle left")
        {
            ball.velocity = new Vector2(speed, leftbounce * 2f);
        }
        if (collision.gameObject.name == "paddle right")
        {
            ball.velocity = new Vector2(-speed, rightbounce * 2f);
        }

        
        
        
        }

    }

        

