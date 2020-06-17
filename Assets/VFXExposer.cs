using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class VFXExposer : MonoBehaviour
{


    [SerializeField] ParticleSystem walkingPS = null;


    public void ChangeWalkingFX(bool enabled)
    {
        walkingPS.gameObject.SetActive(enabled);
    }


    public void walkEmit(int count)
    {
        walkingPS.Emit(count);
    }
}
