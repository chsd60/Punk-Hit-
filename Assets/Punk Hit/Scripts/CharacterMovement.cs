using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

    public Rigidbody rbProtagonista;
    
    public float speed;
    private float orientation;
    //Roba che sto provando, al momento la lascio così, probabilmente da rimuovere
    private Vector3 speedCalc;

    void Start() {
        rbProtagonista = GetComponent<Rigidbody>();
    }


    void Update() {
        orientation = Input.GetAxisRaw("Horizontal");
        //vedi riga 12
        speedCalc = transform.forward * speed * orientation;
        rbProtagonista.AddForce(speedCalc, ForceMode.VelocityChange);
        
    }
}
