using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSystem : MonoBehaviour {

    public float pushSpeed;

    private void Start() {
        //DeleteThis()
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Spingibile")) {
            other.attachedRigidbody.AddForce(transform.forward * pushSpeed, ForceMode.Impulse);
        } else if (other.gameObject.CompareTag("Distruggibile")) {
            other.gameObject.SetActive(false); //ancora da testare
        }
    }

    /** IEnumerator DeleteThis() {
        inserire script, aspetta 1 secondo e distruggi il proiettile.
    } **/
}
