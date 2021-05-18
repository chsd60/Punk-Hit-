using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupNote : PickupPoints
{
    protected override void Pick()
    {
        // TODO: notificare al game manager che è stata presa una nota, in modo tale che venga aggiornato il conteggio.
        base.Pick();
    }
}
