using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeLogic : MonoBehaviour
{

    Animator spikeTrigger;

    private const string animTrigger = "StartSpikeUp";

    private bool triggered = false;
    
    public void resetTriggeredBool()
    {
        triggered = false;
    }

    private void Start()
    {
        spikeTrigger = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!triggered)
        {
            spikeTrigger.SetTrigger(animTrigger);
            triggered = true;
        }
    }
}
