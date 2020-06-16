using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class VFXExposer : MonoBehaviour
{


    [SerializeField] ParticleSystem walkingPS = null;


    public void changeWalkingFX(bool enabled)
    {
        walkingPS.gameObject.SetActive(enabled);
    }

}
