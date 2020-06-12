using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRolling : baseMovementState
{
    Rigidbody2D rb;

    protected override void Awake()
    {
        base.Awake();
        rb = GetComponent<Rigidbody2D>();
        owner.onPlayerRoll.Invoke();
    }

    public override void Enter()
    {
        base.Enter();
        rb.velocity = rb.velocity.normalized;
        rb.velocity *= owner.movementSettings.rollDistance / owner.movementSettings.rollTime;
        owner.playerAnimator.SetTrigger("PlayerRollTrigger");
        StartCoroutine(endRoll());
    }

    private IEnumerator endRoll()
    {
        yield return new WaitForSeconds(owner.movementSettings.rollTime);
        owner.playerAnimator.SetTrigger("PlayerEndRoll");
        owner.onPlayerEndRoll.Invoke();
        owner.CurrentState = owner.GetState<PlayerMovementState>();
        
    }

    public override void Exit()
    {
        base.Exit();
    }
}
