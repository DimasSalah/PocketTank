using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerupEffect : ScriptableObject
{
    // Start is called before the first frame update
   public abstract void Apply(GameObject target);
}
