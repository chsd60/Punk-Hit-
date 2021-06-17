using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSystem : MonoBehaviour {

    public GameObject ondaSonora;
    //public float pushSpeed;
    public float waveSpeed;
    public float fineOnda;

    private void Start() {
        GetComponent<Rigidbody>().AddForce(transform.forward * waveSpeed, ForceMode.Impulse);
        StartCoroutine(DeleteThis());
    }


    // Probabilmente dovrò spostare tutto in script diversi da mettere ai singoli GameObject.

    //TODO: Creare script diversi per ogni onda.
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.GetComponent<DestroyableBase>() != null) {
            other.gameObject.GetComponent<DestroyableBase>().DestroyItem();
        }
        Destroy(gameObject);
    }

    protected virtual void InitialPush() {
        GetComponent<Rigidbody>().AddForce(transform.forward * waveSpeed, ForceMode.Impulse);
        StartCoroutine(DeleteThis());
    }

    IEnumerator DeleteThis() {
        yield return new WaitForSeconds(fineOnda);
        Destroy(ondaSonora);
    }
}
