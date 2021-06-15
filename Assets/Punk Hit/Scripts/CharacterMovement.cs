using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

    public Rigidbody rbProtagonista;
    
    public float speed;
    private float orientation;
    private Vector3 speedCalc;
    public float speedDimezzata;

    private GroundCheck _gCheck;
    private DisableWallMovement _wCheck;
    void Start() {
        rbProtagonista = GetComponent<Rigidbody>();
        _gCheck = gameObject.GetComponent<GroundCheck>();
        _wCheck = gameObject.GetComponent<DisableWallMovement>();
    }


    void FixedUpdate() {


        orientation = Input.GetAxisRaw("Horizontal");
        if (_wCheck.touchesRWall) orientation = Mathf.Clamp(orientation, -1, 0);
        else if (_wCheck.touchesLWall) orientation = Mathf.Clamp(orientation, 0, 1);
        speedCalc = transform.right * speed * orientation;

        if (!_gCheck.isGrounded) speedCalc /= speedDimezzata;

        rbProtagonista.AddForce(speedCalc, ForceMode.Force);
    }
}
