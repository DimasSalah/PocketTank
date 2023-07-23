using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/HealthBuff")]
public class HealthBuff : PowerupEffect
{
    public int amount;

    public override void Apply(GameObject target)
    {
        Damagable damagable = target.GetComponent<Damagable>();
        if (damagable != null)
        {
            damagable.Heal(amount);
        }
    }
}
