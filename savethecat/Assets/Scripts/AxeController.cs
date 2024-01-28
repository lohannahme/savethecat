using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class AxeController : MonoBehaviour
{   
    private Rigidbody2D rb;
    private GameObject player;
    private bool facingRight = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        facingRight = player.GetComponent<Movement>().isFacingRight;
        float speed = player.GetComponent<PlayerStats>().GetSpeed() * 150;

        if (facingRight)
        {
            rb.AddForce(player.transform.right * (speed-50) + player.transform.up * speed );
        }
        else
        {
            rb.AddForce(-player.transform.right * (speed -50) + player.transform.up * speed );
        }
    }
}
