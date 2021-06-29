using System;
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
    
    private VariableManager _varMgr;

    private Animator _animator;

    public void Start() {
        StartCoroutine("Init");
    }

    IEnumerator Init()
    {
        yield return new WaitForEndOfFrame();
        _varMgr = FindObjectOfType<VariableManager>();
        rbProtagonista = GetComponent<Rigidbody>();
        _gCheck = gameObject.GetComponent<GroundCheck>();
        _wCheck = gameObject.GetComponent<DisableWallMovement>();
        _animator = GetComponentInChildren<Animator>();
    }


    void Update()
    {
        if (_varMgr == null || _varMgr.GetGamePaused()) return;
        orientation = Input.GetAxisRaw("Horizontal");
        if (_wCheck.touchesRWall) orientation = Mathf.Clamp(orientation, -1, 0);
        else if (_wCheck.touchesLWall) orientation = Mathf.Clamp(orientation, 0, 1);
        speedCalc = (transform.right * speed * orientation) * Time.deltaTime * 100;

        if (!_gCheck.isGrounded)
        {
            speedCalc *= moltMovimentoInCaduta;
        }

        if (IsFallingDown())
        {
            rbProtagonista.AddForce(transform.up * -1 * forzaCaduta, ForceMode.Force);
        }

        rbProtagonista.AddForce(speedCalc, ForceMode.Force);

        _animator.SetBool("Movimento", Math.Abs(orientation) > Single.Epsilon);
        
    }
    
    public bool IsFallingDown()
    {
        return !gameObject.GetComponent<GroundCheck>().isGrounded && rbProtagonista.velocity.y < 0;
    }

}
