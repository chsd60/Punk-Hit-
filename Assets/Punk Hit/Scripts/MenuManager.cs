using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {

    public bool menuStop = false;
    private bool chiudiMenu = true; //da mettere a posto, al momento quando premo il pulsante si attiva sia l'apertura che la chiusura del menu simultaneamente
    public GameObject pausaUI;

    private VariableManager _varMgr;
    
    public void Start() {
        Time.timeScale = 1;
        StartCoroutine("Init");
    }

    IEnumerator Init()
    {
        yield return new WaitForEndOfFrame();
        _varMgr = FindObjectOfType<VariableManager>();
    }

    void Update()
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
        Time.timeScale = 0;
        _varMgr.SetGamePaused(true);
        menuStop = true;
        pausaUI.SetActive(true);
    }

    public void CloseMenu() {
        _varMgr.SetGamePaused(false);
        Time.timeScale = 1;
        menuStop = false;
        pausaUI.SetActive(false);
    }

    public void AttivaChiudiMenu() {
        chiudiMenu = true;
    }
}
