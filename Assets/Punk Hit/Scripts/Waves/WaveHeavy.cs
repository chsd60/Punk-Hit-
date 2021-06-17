using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveHeavy : WaveSystem {

    public float forzaOndaPesante;

    protected override void InitialPush() {
        waveSpeed = forzaOndaPesante;
        base.InitialPush();
    }
}
