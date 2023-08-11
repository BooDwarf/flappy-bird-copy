using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementInput : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rb;

    public float jumpForce;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump")) 
        {
            Debug.Log(Input.anyKeyDown);
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);     
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y>0)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        } 
    }
}
