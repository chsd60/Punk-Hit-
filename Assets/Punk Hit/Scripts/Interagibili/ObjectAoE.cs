using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class ObjectAoE : MonoBehaviour {

    private Collider explosionCollider;
    private void Start() {
        explosionCollider = GetComponent<Collider>();
        explosionCollider.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other) {
        
    }

}
