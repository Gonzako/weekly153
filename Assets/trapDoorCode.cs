using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapDoorCode : MonoBehaviour
{

    public UnityEngine.Events.UnityEvent onTrapDoorUnlock;
    [SerializeField] public playerStepEvent onPlayerStep = new playerStepEvent();

    private bool isOpen;

    public void openTrapDoor()
    {
        isOpen = true;
        onTrapDoorUnlock.Invoke();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        onPlayerStep.Invoke(isOpen);
        if (!isOpen)
        {

        }
    }

}

[System.Serializable]
public class playerStepEvent : UnityEngine.Events.UnityEvent<bool> { }