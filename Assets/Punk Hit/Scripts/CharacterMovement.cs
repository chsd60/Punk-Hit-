using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

    //Da rimuovere quando è finito il testing
    public bool movementTest = true;

    public Rigidbody rbProtagonista;
    
    //Da unificare quando è finito il testing
    public float speed;
    private float orientation;

    void Start() {
        rbProtagonista = GetComponent<Rigidbody>();
    }


    void Update() {
        orientation = Input.GetAxisRaw("Horizontal");
        // rbProtagonista.AddForce(transform.forward * speed * orientation, ForceMode.IDENTIFIER);
        
    }
}
