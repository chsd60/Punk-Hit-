using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateWaves : MonoBehaviour {

    public GameObject soundWave;
    public speed = 100f;

    void Start() {
        
    }

    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            Rigidbody clone = (Rigidbody)Instantiate(soundWave, spawnPoint.position);
            clone.velocity = spawnPoint.TransformDirection(Vector3.forward * 20);
        }
    }
}
