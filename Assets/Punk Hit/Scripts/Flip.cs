using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour {

    public GameObject skins;
    public bool isFlipped = true;

    private VariableManager _varMgr;

    public void Start() {
        StartCoroutine("Init");
    }

    IEnumerator Init()
    {
        yield return new WaitForEndOfFrame();
        _varMgr = FindObjectOfType<VariableManager>();
    }


    void Update()
    {
        if (_varMgr == null || _varMgr.GetGamePaused()) return;
        if (Input.GetAxis("Horizontal") > 0 && isFlipped) {
            isFlipped = false;

            
            Vector3 v = skins.transform.rotation.eulerAngles; //speen
            v.y = 0;
            transform.rotation = Quaternion.Euler(v);

            Debug.Log("Flip!");
        } else if (Input.GetAxis("Horizontal") < 0 && isFlipped == false) {
            isFlipped = true;

            Vector3 v = skins.transform.rotation.eulerAngles; //speen
            v.y = 180;
            transform.rotation = Quaternion.Euler(v);

            Debug.Log("Unflip!");
        }
    }
}
