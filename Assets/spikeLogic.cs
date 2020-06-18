using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeLogic : MonoBehaviour
{

    public AudioSource spikeStart   = null;
    public AudioSource spikeHurtbox = null;


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
            Debug.LogFormat("{0} collided with {1} triggered start animation", this.gameObject.name, collision.gameObject.name);
            spikeStart.Play();
        }
        else
        {

            Debug.LogFormat("{0} damaged {1}", gameObject.name, collision.gameObject.name);

            if (collision.CompareTag("Player"))
            {
                var dmg = collision.GetComponent<Mortal>();
                if(dmg.enabled)
                    dmg.Damage(100);
            }
        }
    }


    public void playOnSound()
    {
        spikeHurtbox.Play();
    }
}
