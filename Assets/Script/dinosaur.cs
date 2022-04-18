using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class dinosaur : MonoBehaviour
{
    Rigidbody2D rb;
    public float jump;
    public float longjump;
    bool isJumping;
    public Manger gm;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isJumping = false;
    }
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& isJumping==false)
        { 
            
            rb.velocity = new Vector2(0, jump);
            isJumping = true;
           
        }
        if (Input.GetKeyDown(KeyCode.E) && isJumping == false)
        {

            rb.velocity = new Vector2(0, longjump);
            isJumping = true;
        }

        //if (Input.GetKey(KeyCode.Space) && isJumping == false )
        // { 
        //     rb.velocity = new Vector2(longjump, jump);
        //     isJumping = true;

        // }

    }
     private void OnCollisionEnter2D(Collision2D collision)
    {
        isJumping = false;
        if (collision.gameObject.tag=="cactus")
        {
            gm.GameOver();
        }
    }  

}
