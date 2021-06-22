using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {

    private float distanceToGround;
    public bool isGrounded;
    private Animator _animator;
    void Start() {
        distanceToGround = GetComponent<Collider>().bounds.extents.y;
        _animator = GetComponentInChildren<Animator>();
    }

    void Update() {
        if (Physics.Raycast(transform.position, -Vector3.up, distanceToGround + 0.1f) ||
            Physics.Raycast(transform.position + new Vector3(0.5f, 0, 0), -Vector3.up, distanceToGround + 0.1f) ||
            Physics.Raycast(transform.position + new Vector3(-0.5f, 0, 0), -Vector3.up, distanceToGround + 0.1f)) {
            isGrounded = true;
        } else {
            isGrounded = false;
            //Debug.Log("air");
        }
        _animator.SetBool("aTerra", isGrounded);
    }
}
