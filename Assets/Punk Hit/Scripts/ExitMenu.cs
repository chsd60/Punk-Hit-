using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ExitMenu : MonoBehaviour {

    public UnityEvent ue;
    void Update() {
        if (Input.GetButtonDown("Menu")) {
            ue.Invoke();
        }
    }
}
