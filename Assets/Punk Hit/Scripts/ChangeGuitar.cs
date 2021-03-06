using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGuitar : MonoBehaviour {

    private VariableManager vManager;

    public GameObject chitarraM;
    public GameObject chitarraH;
    public GameObject chitarraL;
    public GameObject chitarraS;

    private void Start()
    {
        StartCoroutine("CheckGuitar");
    }

    IEnumerator CheckGuitar()
    {
        yield return new WaitForSeconds(.01f);
        vManager = FindObjectOfType<VariableManager>();
        UpdateGuitarSkin(vManager.GetSelectedGuitar());
    }

    //TODO: Aggiungere "SelectPreviousGuitar"
    private void Update() {
        if(Input.GetButtonDown("Fire3")) {
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
