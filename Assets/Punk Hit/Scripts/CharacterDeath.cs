using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterDeath : MonoBehaviour {

    // Respawn = Numero di scena corrente
    //timeToDeath indica dopo quanto il giocatore rispawnerà
    public float timeToRespawn;

    private SpawnManager _sm;

    public AudioClip sfxMorte;
    public AudioSource source;
    public GameObject vfxMorte;
    
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
        AudioClip audio = sfxMorte;
        if (source != null)
        {
            source.clip = audio;
            source.Play();
        }
        //piglia transform giocatore, spawna vfx in quel punto
        yield return new WaitForSeconds(timeToRespawn);
        _sm.SetPlayerPosition();
    }
}
