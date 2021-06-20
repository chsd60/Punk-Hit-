using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {

    public bool menuStop = false;
    private bool chiudiMenu = true; //da mettere a posto, al momento quando premo il pulsante si attiva sia l'apertura che la chiusura del menu simultaneamente
    public GameObject pausaUI;

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Menu") && !menuStop) {
            chiudiMenu = false;
            Invoke("AttivaRichiudiMenu", 0.1f);
            OpenMenu();
        }

        if (Input.GetButtonDown("Menu") && menuStop && chiudiMenu) {
            CloseMenu();
        }
    }

    public void OpenMenu() {
        Debug.Log("Hey");
        Time.timeScale = 0;
        menuStop = true;
        pausaUI.SetActive(true);
    }

    public void CloseMenu() {
        Debug.Log("Listen");
        Time.timeScale = 1;
        menuStop = false;
        pausaUI.SetActive(false);
    }

    public void AttivaChiudiMenu() {
        chiudiMenu = true;
    }
}
