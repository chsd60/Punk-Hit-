using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupGuitar : PickupBase
{
    public GuitarTypes type;
    protected override void Pick()
    {
        FindObjectOfType<VariableManager>().AddGuitar(type);
        // Assegnare la chitarra
        
        base.Pick();
    }
}
