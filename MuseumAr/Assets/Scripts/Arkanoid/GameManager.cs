using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int lives = 3;

    public GameObject ball;
    private Ball ballcomp;
    private Rigidbody2D ballrb;
    public GameObject player;
    public GameObject level;

    private int state = 0;

    // Start is called before the first frame update
    void Start()
    {
        ballcomp = ball.GetComponent<Ball>();
        ballrb = ball.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(state == 1)
        {
            CheckBall();
        }
        else if(state == 0 && (Input.touchCount > 0 || Input.anyKey))
        {
            state = 1;
            ballcomp.Init();
        }
    }

    void CheckBall()
    {
        if(ballrb.position.y < -5)
        {
            LoseLive();
        }
    }

    void LoseLive()
    {
        state = 1;
        ballcomp.Init();
    }
}
