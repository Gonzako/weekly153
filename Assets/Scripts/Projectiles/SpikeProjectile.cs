using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeProjectile : MonoBehaviour
{
    [SerializeField] private float damage = 0F;

    private Rigidbody2D _rb;

    private void OnEnable()
    {
        _rb.GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        IMortal mortal = collision.transform.GetComponent<IMortal>();
        if (mortal != null)
        {
            mortal.Damage(damage);
            Destroy(transform.gameObject);
        }
        //add more force reduced by 50% of the current
        _rb.AddForce(Vector2.Reflect(transform.right, collision.transform.position.normalized) * _rb.velocity / 2, ForceMode2D.Impulse);
    }
}
