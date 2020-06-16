using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zRotator : MonoBehaviour
{
    public float velocity = 15f;


    // Update is called once per frame
    void Update()
    {
        var frameStep = Quaternion.AngleAxis(velocity*Time.deltaTime, Vector3.forward);
        transform.rotation *= frameStep;
    }
}
