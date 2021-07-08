using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterDeath : MonoBehaviour {

    // Respawn = Numero di scena corrente
    //timeToDeath indica dopo quanto il giocatore rispawnerà
    public float timeToRespawn = 1;
    private Transform playerLocation;

    private SpawnManager _sm;
    
    void Start() {
 //       currentScene = SceneManager.GetActiveScene().buildIndex;
        _sm = FindObjectOfType<SpawnManager>();
    }
    // Se il giocatore tocca il nemico, parte la coroutine
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            StartCoroutine(DeadPlayer());
    //        Debug.Log("Dentro");
        }
    }

    // Fa rispawnare il giocatore
    IEnumerator DeadPlayer() {
        playerLocation = this.transform;
        yield return new WaitForSeconds(timeToRespawn);
        _sm.SetPlayerPosition();
    }
}
