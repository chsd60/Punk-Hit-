using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(Collider))]
public class PickupBase : MonoBehaviour
{
    public string[] tags;

    public GameObject spawnedPrefab;
    private AudioSource _as;
    public AudioClip sfxPick;
    
    void Start()
    {
        GetComponent<Collider>().isTrigger = true;
        _as = FindObjectOfType<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        foreach (var t in tags)
        {
            if (!other.gameObject.CompareTag(t)) continue;
            Pick();
            break;
        }
    }

    protected virtual void Pick()
    {
        // Estendere questa funzione per attivare il pickup
        if (spawnedPrefab != null)
        {
            Instantiate(spawnedPrefab, transform.position, transform.rotation);
        }
        AudioClip audio = sfxPick;
        if (_as != null) {
            _as.clip = audio;
            _as.Play();
        }
        Destroy(this.gameObject);
    }
}
