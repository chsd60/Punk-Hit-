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
        RaycastHit rayHit;
        if (Physics.Raycast(transform.position, -Vector3.up, out rayHit, distanceToGround + 0.1f) && rayHit.transform.tag == "Piattaforma" ||
            Physics.Raycast(transform.position + new Vector3(0.5f, 0, 0), -Vector3.up, out rayHit, distanceToGround + 0.1f) && rayHit.transform.tag == "Piattaforma" ||
            Physics.Raycast(transform.position + new Vector3(-0.5f, 0, 0), -Vector3.up, out rayHit, distanceToGround + 0.1f) && rayHit.transform.tag == "Piattaforma") { 
            isGrounded = true;
        } else {
            isGrounded = false;
            //Debug.Log("air");
        }
        _animator.SetBool("aTerra", isGrounded);
    }
}
