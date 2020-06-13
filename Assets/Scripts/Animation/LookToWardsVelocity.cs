using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookToWardsVelocity : MonoBehaviour
{
    public Transform rotateTarget;
    public Rigidbody2D info;
    public float velocity;

    private void Update()
    {
        ///        headBone.localRotation = Quaternion.Slerp(
        ///  currentLocalRotation,
        ///  targetLocalRotation,
        ///  1 - Mathf.Exp(-headTrackingSpeed * Time.deltaTime)
        ///);
        ///
        if (info.velocity != Vector2.zero)
        {
            var currentLocalRot = rotateTarget.localRotation;
            //var targetLocalRotation = Quaternion.Euler(info.velocity);
            var ignoreY = info.velocity.normalized;
            //ignoreY.y = 0;
            var targetLocalRotation = Quaternion.AngleAxis(Mathf.Atan2(ignoreY.y, ignoreY.x)*Mathf.Rad2Deg, Vector3.forward);

            rotateTarget.localRotation = Quaternion.Slerp(currentLocalRot, targetLocalRotation,
                1 - Mathf.Exp(-velocity * Time.deltaTime)); 
        }
    }

}
