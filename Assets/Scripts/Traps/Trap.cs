using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public GameEvent onTrapActivated;
    [SerializeField] SpikeShooter[] _shooters;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var rb = collision.transform.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            onTrapActivated?.Raise();
            Debug.Log("[TRAP]: Trap was activated by " + collision.transform.name, transform.gameObject);

            foreach(SpikeShooter shooter in _shooters)
            {
                shooter.Shoot();
            }
        }
    }
}
