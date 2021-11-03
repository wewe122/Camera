using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int jump;
    public int speed;
    public bool isGround;
    public float groundRadius;
    public LayerMask WhatisGround;
    public Transform[] groundPoints;
    Vector2 direction;
    Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        direction = Vector2.right;
        rb2d = GetComponent<Rigidbody2D> ();
    }

    void Update()
    {
        isGround = CheakIfISGround();
        if(isGround && Input.GetKeyDown("up"))
        {
            rb2d.AddForce(new Vector2(0,jump),ForceMode2D.Impulse);
        }
    }

    bool CheakIfISGround()
    {
        for(int i = 0; i < groundPoints.Length; i++)
        {
            if(Physics2D.OverlapCircle(groundPoints[i].position,groundRadius,WhatisGround))
            return true;
        }

        return false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float inputX = Input.GetAxis("Horizontal");

        Debug.Log(inputX);
        if(inputX < 0)
        {
            direction = Vector2.left;
        }
        else if(inputX > 0)
        {
            direction = Vector2.right;
        }
        
        transform.localScale = new Vector2(direction.x, transform.localScale.y);
        rb2d.velocity = new Vector2(inputX * speed, rb2d.velocity.y);
    }
}
