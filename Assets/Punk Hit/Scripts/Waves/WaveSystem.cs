using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSystem : GenericWSystem {

    //Distrugge l'onda.
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.GetComponent<DestroyableBase>() != null) {
            other.gameObject.GetComponent<DestroyableBase>().DestroyItem();
        }
        Destroy(gameObject);
    }
     protected override void InitialPush() {
        GetComponent<Rigidbody>().AddForce(transform.forward * waveSpeed, ForceMode.Impulse);
        base.InitialPush();
     }
}
