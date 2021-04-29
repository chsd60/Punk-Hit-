using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJump : MonoBehaviour {

    public Rigidbody rbProtagonista;
    public float jumpForce;
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {

        if (Input.GetButtonDown("Jump")) {
            rbProtagonista.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        }
    }
}
