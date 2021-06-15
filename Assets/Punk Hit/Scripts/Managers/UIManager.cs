using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Text puntiUI;
    public Text noteUI;
    public Image guitarUI;
    public Sprite guitarM;
    public Sprite guitarH;
    public Sprite guitarL;
    public Sprite guitarS;

    public void UpdatePoints(int pts) {
        puntiUI.text = "Punti: " + pts;
    }

    public void UpdateNotes(int note) {
        noteUI.text = "Note: " + note;
    }

    //public void UpdateFans()

    public void UpdateGuitar(GuitarTypes type) {

        switch (type) {
            case GuitarTypes.Leggera:
                guitarUI.sprite = guitarL;
                break;
            case GuitarTypes.Pesante:
                guitarUI.sprite = guitarH;
                break;
            case GuitarTypes.OP:
                guitarUI.sprite = guitarS;
                break;
            default: guitarUI.sprite = guitarM;
                break;
        }

        Debug.Log("Chitarra Selezionata: " + type);
    }
}
