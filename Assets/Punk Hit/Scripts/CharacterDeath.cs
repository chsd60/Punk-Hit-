using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterDeath : MonoBehaviour {

    // Respawn = Numero di scena corrente
    //timeToDeath indica dopo quanto il giocatore rispawnerà
    public float timeToRespawn;

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

    // Disattiva il game object del giocatore, e dopo due secondi ricarica la scena.
    // Probabilmente andrà cambiato.
    IEnumerator DeadPlayer() {

        //La riga seguente servirà per quando verrà migliorato il sistema di respawn in futuro
        // GameObject.Find("Player").GetComponent<PlayerMovement>().Death();
        yield return new WaitForSeconds(timeToRespawn);
        _sm.SetPlayerPosition();
    }
}
