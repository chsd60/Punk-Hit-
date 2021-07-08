using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSecret : PickupBase
{
    protected override void Pick()
    {
        var sc = FindObjectOfType<SkinChanger>();
        if(sc != null)
            sc.ChangeSkin();
    }
}
