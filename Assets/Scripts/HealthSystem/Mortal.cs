using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mortal : MonoBehaviour, IMortal
{

    [SerializeField] private FloatGameEvent onDamage;
    [SerializeField] private FloatGameEvent onHeal;

    [SerializeField] private FloatVariable _Health = null;
    [SerializeField] private float _MaxHealth = 0.0F;

    public void Damage(float damage)
    {
        _Health.Value -= Mathf.Clamp(_Health.Value - damage, 0, _MaxHealth);
    }

    public void Heal(float healthpoints)
    {
        _Health.Value += Mathf.Clamp(_Health.Value + healthpoints, 0, _MaxHealth);
    }
}
