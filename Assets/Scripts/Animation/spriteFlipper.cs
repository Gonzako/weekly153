using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteFlipper : MonoBehaviour
{
    [SerializeField] Rigidbody2D information = null;
    [SerializeField] SpriteRenderer target = null;


    private void FixedUpdate()
    {

        if (Mathf.Abs(information.velocity.x) > 0)
        {
            var newLocal = transform.localScale;
            newLocal.x = information.velocity.x > 0 ? Mathf.Abs(newLocal.x) : -Mathf.Abs(newLocal.x);
            transform.localScale = newLocal;
        }
    }


}
