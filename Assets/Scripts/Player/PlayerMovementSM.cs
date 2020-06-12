using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementSM : BaseStateMachine
{

    public MovementSettings movementSettings;

    public UnityEngine.Events.UnityEvent onPlayerRoll;
    public UnityEngine.Events.UnityEvent onPlayerEndRoll;

    [HideInInspector]
    public Animator playerAnimator;

    private void Start()
    {
        playerAnimator = GetComponent<Animator>();
        this.Transition(GetState<PlayerMovementState>());
    }



}
