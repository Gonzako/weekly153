using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementState : baseMovementState
{

    

    Vector2 inputVect;
    Camera cam;
    Rigidbody2D rb;


    protected override void Awake()
    {
        base.Awake();
        cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        inputVect = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        owner.playerAnimator.SetBool("IsPlayerWalking", inputVect.magnitude > 0.2f);

        angleToMouse();

        if (Input.GetButtonDown("Fire1"))
        {
            owner.CurrentState = owner.GetState<PlayerRolling>();
            
        }
        //Look towards mouse
    }



    private void FixedUpdate()
    {
        //Move depending of input
        var inptMagni = inputVect.magnitude;
        if (inptMagni > 1)
        {
            inputVect = inputVect / inptMagni;
        }
        //var velX = transform.right * inputVect.x;
        //var velY = transform.up * inputVect.y;


        rb.velocity = inputVect * owner.movementSettings.moveSpeed;
        
        //rb.velocity = (velX +  velY) * owner.movementSettings.moveSpeed;
    }
    
    private void angleToMouse()
    {
        var mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        var dir = mousePos - transform.position;

        dir.z = 0;

        if(dir.magnitude > 0f)
            transform.up = dir.normalized;
        
    }
}
