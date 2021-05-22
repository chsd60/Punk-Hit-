using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSystem : MonoBehaviour {

    public float pushSpeed;


    private void Start() {
        DeleteThis();
    }

    // Probabilmente dovrò spostare tutto in script diversi da mettere ai singoli GameObject.
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Spingibile")) {
            other.attachedRigidbody.AddForce(transform.forward * pushSpeed, ForceMode.Impulse);
        } else if (other.gameObject.CompareTag("Distruggibile")) {
            other.gameObject.SetActive(false);
        } 
    }

    IEnumerator DeleteThis() {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
