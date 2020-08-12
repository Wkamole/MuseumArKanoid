using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update

    public float initForce = 100000;
    private Rigidbody2D rb;
    public GameObject GM;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    public void Init()
    {
        rb.position = Vector2.zero;
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
        rb.constraints = RigidbodyConstraints2D.None;
        rb.AddForce(new Vector2(0, -initForce));
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "tile")
        {
            GM.GetComponent<GameManager>().TileHit();
        }

    }

}
