using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGuitar : MonoBehaviour {

    private VariableManager vManager;

    public GameObject chitarraM;
    public GameObject chitarraH;
    public GameObject chitarraL;
    public GameObject chitarraS;

    private void Start() {
        vManager = FindObjectOfType<VariableManager>();
        UpdateGuitarSkin(vManager.GetSelectedGuitar());
    }

    private void Update() {
        if(Input.GetButtonDown("ChangeGuitar")) {
            vManager.SelectNextGuitar();
            UpdateGuitarSkin(vManager.GetSelectedGuitar());
        }
    }

    public void UpdateGuitarSkin(GuitarTypes type) {
        chitarraM.SetActive(type == GuitarTypes.Media);
        chitarraL.SetActive(type == GuitarTypes.Leggera);
        chitarraH.SetActive(type == GuitarTypes.Pesante);
        chitarraS.SetActive(type == GuitarTypes.OP);
    }
}
