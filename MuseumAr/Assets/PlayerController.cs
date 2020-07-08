using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject player;
    public Rigidbody2D playerRig2D;
    public float speed;
    public float maxRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        if (x < 0)
        {
            MoveLeft();
        }
        if(x > 0)
        {
            MoveRight();
        }
        if(x == 0)
        {
            Stop();
        }

    }

    void MoveRight()
    { 
        playerRig2D.velocity = new Vector2(speed,0);
    }

    void MoveLeft()
    {
        playerRig2D.velocity = new Vector2(-speed, 0);

    }

    void Stop()
    {
        playerRig2D.velocity = Vector2.zero;
    }
}
