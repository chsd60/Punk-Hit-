using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Text puntiUI;
    public Text noteUI;

    public void UpdatePoints(int pts) {
        puntiUI.text = "Punti: " + pts;
    }

    public void UpdateNotes(int note) {
        noteUI.text = "Note: " + note;
    }

    //public void UpdateFans()
}
