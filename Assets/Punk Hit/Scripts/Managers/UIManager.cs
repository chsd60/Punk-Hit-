using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    //Testo
    public Text puntiUI;
    public Text noteUI;

    //Immagini Chitarre
    public Image guitarUI;
    public Sprite guitarM;
    public Sprite guitarH;
    public Sprite guitarL;
    public Sprite guitarS;

    //Immagini Vinile

    private int punti;
    public int minArg;
    public int minOro;
    public int minPlat;
    public int minDiam;
    public Image vinylUI;
    public Sprite vinile;
    public Sprite vinileArg;
    public Sprite vinileOro;
    public Sprite vinilePlat;
    public Sprite vinileDiam;

    public void Start() {
        Invoke("UpdateDisc", 0);
    }
    public void UpdatePoints(int pts) {
        punti = pts;
        puntiUI.text = "Punti: " + pts;
        Invoke("UpdateDisc", 0);
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

    public void UpdateDisc() {
        if (punti >= minArg && punti < minOro) {
            vinylUI.sprite = vinileArg;
        } else if (punti >= minOro && punti < minPlat) {
            vinylUI.sprite = vinileOro;
        } else if (punti >= minPlat && punti < minDiam) {
            vinylUI.sprite = vinilePlat;
        } else if (punti >= minDiam) {
            vinylUI.sprite = vinileDiam;
        } else {
            vinylUI.sprite = vinile;
        }
    }
}
