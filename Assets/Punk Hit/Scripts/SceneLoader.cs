using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    [SerializeField] private Scenes sceneToLoad;
    public void LoadNextScene() {
        SceneManager.LoadScene(sceneToLoad.ToString(), LoadSceneMode.Single);
    }
}
