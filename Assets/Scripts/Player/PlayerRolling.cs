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
        owner.playerAnimator.SetTrigger("PlayerRollTrigger");
        owner.onPlayerRoll.Invoke();
    }

    public override void Enter()
    {
        base.Enter();
        rb.velocity = rb.velocity.normalized;
        rb.velocity *= owner.movementSettings.rollDistance / owner.movementSettings.rollTime;
        StartCoroutine(endRoll());
    }

    private IEnumerator endRoll()
    {
        yield return new WaitForSeconds(owner.movementSettings.rollTime);
        owner.CurrentState = owner.GetState<PlayerMovementState>();
        owner.playerAnimator.SetTrigger("PlayerEndRoll");
    }
}
