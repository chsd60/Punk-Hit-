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

    public AudioClip sfxMorte;
    private AudioSource source;
    public GameObject vfxMorte;
    
    void Start() {
 //       currentScene = SceneManager.GetActiveScene().buildIndex;
        _sm = FindObjectOfType<SpawnManager>();
        source = FindObjectOfType<AudioSource>();
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
        playerLocation = this.transform;
        if (vfxMorte != null) Instantiate(vfxMorte, playerLocation.position, playerLocation.rotation);
        yield return new WaitForSeconds(timeToRespawn);
        _sm.SetPlayerPosition();
    }
}
