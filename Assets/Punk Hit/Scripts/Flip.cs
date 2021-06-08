using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour {

    public GameObject waveGenL;
    public GameObject waveGenR;
    public GameObject skins;
    public bool isFlipped = true;


    private void Start() {
        if (waveGenL) {
            waveGenL.SetActive(false);
        }
    }
    void Update() {
        if (Input.GetAxis("Horizontal") > 0 && isFlipped) {
            isFlipped = false;

            waveGenL.SetActive(false); //cambia spawner delle onde
            waveGenR.SetActive(true);

            
            Vector3 v = skins.transform.rotation.eulerAngles; //speen
            v.y = 0;
            transform.rotation = Quaternion.Euler(v);

            Debug.Log("Flip!");
        } else if (Input.GetAxis("Horizontal") < 0 && isFlipped == false) {
            isFlipped = true;

            waveGenR.SetActive(false);
            waveGenL.SetActive(true);

            Vector3 v = skins.transform.rotation.eulerAngles; //speen
            v.y = 180;
            transform.rotation = Quaternion.Euler(v);

            Debug.Log("Unflip!");
        }
    }
}
