using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public bool grounded;
    public float jumpPower = 6.5f;
    

    private Rigidbody2D rb2d;
    private bool jump;
    private bool doubleJump;


    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (grounded)
        {
            doubleJump = true;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (grounded)
            {
                jump = true;
                doubleJump = true;
            }
            else if (doubleJump)
            {
                jump = true;
                doubleJump = false;
            }

        }
    }

    private void FixedUpdate()
    {
        if (jump)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, 0);
            rb2d.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            jump = false;
        }
    }

    private void OnBecameInvisible()
    {
        transform.position = new Vector3(-1, 0, 0);
    }

}
