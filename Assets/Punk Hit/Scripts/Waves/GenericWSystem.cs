using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericWSystem : MonoBehaviour {

    public GameObject ondaSonora;
    //public float pushSpeed;
    public float waveSpeed;
    public float fineOnda;

    private void Start() {
        Invoke("InitialPush", 0);
        StartCoroutine(DeleteThis());
    }

    protected virtual void InitialPush() {
        
    }

    IEnumerator DeleteThis() {
        yield return new WaitForSeconds(fineOnda);
        Destroy(this.gameObject);
    }
}
