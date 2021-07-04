using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    [SerializeField] private int sceneToLoad;
    private GameObject mm;
    public void LoadNextScene() {
        if (sceneToLoad == 0) {
            mm = FindObjectOfType<MixerManager>().gameObject;
            Object.Destroy(mm);
        }
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneToLoad, LoadSceneMode.Single);
    }
}
