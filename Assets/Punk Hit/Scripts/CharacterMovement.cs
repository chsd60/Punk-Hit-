using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CharacterMovement : MonoBehaviour {

    public Rigidbody rbProtagonista;
    
    public float speed;
    private float orientation;
    private Vector3 speedCalc;
    [FormerlySerializedAs("speedDimezzata")]
    public float moltMovimentoInCaduta;
    public float forzaCaduta;

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

        if (!_gCheck.isGrounded)
        {
            speedCalc *= moltMovimentoInCaduta;
        }

        if (IsFallingDown())
        {
            rbProtagonista.AddForce(transform.up * -1 * forzaCaduta, ForceMode.Force);
        }

        rbProtagonista.AddForce(speedCalc, ForceMode.Force);
    }
    
    // London Bridge
    public bool IsFallingDown()
    {
        return !gameObject.GetComponent<GroundCheck>().isGrounded && rbProtagonista.velocity.y < 0;
    }

}
