using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJump : MonoBehaviour {

    public Rigidbody rbProtagonista;
    public float jumpForce;
    private bool grounded;
    private VariableManager _varMgr;

    public void Start() {
        StartCoroutine("Init");
    }

    IEnumerator Init()
    {
        yield return new WaitForEndOfFrame();
        _varMgr = FindObjectOfType<VariableManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_varMgr == null || _varMgr.GetGamePaused()) return;
        
        grounded = gameObject.GetComponent<GroundCheck>().isGrounded;
        if (Input.GetButtonDown("Jump") && grounded) {
                rbProtagonista.AddForce(transform.up * jumpForce, ForceMode.Impulse);
                Debug.Log("Jump");
        }
    }
}
