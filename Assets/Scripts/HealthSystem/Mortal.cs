using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mortal : MonoBehaviour, IMortal
{

    [SerializeField] private FloatGameEvent onDamage;
    [SerializeField] private FloatGameEvent onHeal;
    [SerializeField] private GameObjectEvent onMortalDeath;

    [SerializeField] private FloatVariable _Health = null;
    [SerializeField] private float _MaxHealth = 0.0F;

    private GameObject _me = null;

    private void Start()
    {
        _Health.Value = _MaxHealth;
        _me = transform.gameObject;
    }

    public void Damage(float damage)
    {
        _Health.Value = Mathf.Clamp(_Health.Value - damage, 0, _MaxHealth);

        if(_Health.Value == 0)
        {
           onMortalDeath?.Invoke(_me);
        }
        float remainingHealthPercentage = _Health.Value / _MaxHealth;

        onDamage?.Raise(remainingHealthPercentage);
    }

    public void Heal(float healthpoints)
    {
        _Health.Value = Mathf.Clamp(_Health.Value + healthpoints, 0, _MaxHealth);
    }
}
