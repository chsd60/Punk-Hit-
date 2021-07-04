using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {

    public GameObject pausaUI;

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
        if (Input.GetButtonDown("Menu") && !pausaUI.activeInHierarchy) {
            OpenMenu();
        }
        else if (Input.GetButtonDown("Menu"))
        {
            CloseMenu();
        }
    }

    public void OpenMenu()
    {
        if (!_varMgr) return;
        Time.timeScale = 0;
        _varMgr.SetGamePaused(true);
        pausaUI.SetActive(true);
    }

    public void CloseMenu() {
        Debug.Log("Close");
        if (!_varMgr) return;
        Time.timeScale = 1;
        _varMgr.SetGamePaused(false);
        pausaUI.SetActive(false);
    }

    public void AttivaChiudiMenu() {
        //chiudiMenu = true;
    }
}
