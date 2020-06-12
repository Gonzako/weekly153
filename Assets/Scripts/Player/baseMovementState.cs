using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseMovementState : BaseState
{

    protected PlayerMovementSM owner;

    public override void Enter()
    {
        base.Enter();
        this.enabled = true;
        
    }

    public override void Exit()
    {
        base.Exit();
        this.enabled = false;
    }

    protected virtual void Awake()
    {
        owner = GetComponent<PlayerMovementSM>();
    }
}
