using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour {

    public bool isFlipped = true;

    void Update() {
        if (Input.GetAxis("Horizontal") > 0 /**&& isFlipped**/) {
            //isFlipped = false;
            transform.localScale += new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            Debug.Log("Flip!");
        } else if (Input.GetAxis("Horizontal") < 0 /**&& isFlipped == false**/) {
            //isFlipped = true;
            transform.localScale += new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            Debug.Log("Unflip!");
        }
    }
}
