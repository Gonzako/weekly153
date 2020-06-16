using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapDoorCode : MonoBehaviour
{

    [SerializeField] public playerStepEvent onPlayerStep = new playerStepEvent();


    public void openTrapDoor()
    {
        //isOpen = true;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        onPlayerStep.Invoke(false);
    }

}

[System.Serializable]
public class playerStepEvent : UnityEngine.Events.UnityEvent<bool> { }