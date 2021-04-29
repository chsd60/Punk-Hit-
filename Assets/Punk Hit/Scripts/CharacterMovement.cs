using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {
    public Rigidbody rbProtagonista;

    public float speed;
    private float orientation;
    void Start() {
        rbProtagonista = GetComponent<Rigidbody>();
    }


    void Update() {
        orientation = Input.GetAxisRaw("Horizontal");
        rbProtagonista.AddForce(transform.forward * speed * orientation);
    }
}
