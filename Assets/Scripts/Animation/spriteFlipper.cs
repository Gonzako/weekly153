using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteFlipper : MonoBehaviour
{
    [SerializeField] Rigidbody2D information = null;
    [SerializeField] SpriteRenderer target = null;


    private void FixedUpdate()
    {

        target.flipX = information.velocity.x < 0;

    }


}
