using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMortal
{
    void Damage(float damage);
    void Heal(float healthpoints);
}
