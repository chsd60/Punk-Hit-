using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSelection : MonoBehaviour {

    public GameObject es1;
    public GameObject es2;
    void Update() {
        if (Input.GetButtonDown("Vertical")) {
            es1.SetActive(false);
            es2.SetActive(true);
            Debug.Log("Swap");
        }
    }
}
