using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGrounded : MonoBehaviour
{

    private PlayerController player;
    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start()
    {
        player = GetComponentInParent<PlayerController>();
        rb2d = GetComponentInParent<Rigidbody2D>();
    }
    

    private void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground"|| col.gameObject.tag == "Platform")
        {
            player.grounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground"||col.gameObject.tag == "Platform")
        {
            player.grounded = false;
        }
    }
}
