﻿using System.Collections;
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
            level.GetComponent<LevelManager>().InstantiateLevel();
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
        lives--;
        ballcomp.Init();
        if (lives >= 0) GameOver();
    }

    void GameOver()
    {

    }

    public void TileHit()
    {
        level.GetComponent<LevelManager>().tileAmount--;
        if(level.GetComponent<LevelManager>().tileAmount <= 0)
        {
            LevelCompleted();
        }
    }

    public void LevelCompleted()
    {
        MenuManagerHUD.instance.Loadlevel("SampleScene");
        MenuManagerHUD.instance.unlock2 = true;
        MenuManagerHUD.instance.menus[0].SetActive(true);
    }
}
