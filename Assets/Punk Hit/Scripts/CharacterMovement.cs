using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

    //Da rimuovere quando è finito il testing
    public bool movementTest = true;

    public Rigidbody rbProtagonista;
    
    //Da unificare quando è finito il testing
    public float speedSlittoso;
    public float speedScattoso;
    private float orientation;

    void Start() {
        rbProtagonista = GetComponent<Rigidbody>();
    }


    void Update() {
        orientation = Input.GetAxisRaw("Horizontal");

        //Da togliere if quando è finito il testing
        if (Input.GetKeyDown("m") && movementTest) {
            movementTest = false;
        } else if (Input.GetKeyDown("m") && movementTest == false) {
            movementTest = true;
        }

        if (movementTest) {
            rbProtagonista.AddForce(transform.forward * speedSlittoso * orientation, ForceMode.Acceleration);
        } else {
            rbProtagonista.velocity = transform.forward * speedScattoso * orientation;
        }
    }
}
