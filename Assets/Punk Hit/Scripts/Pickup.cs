using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour {

    /**
     * Bisognerebbe fare ordine in futuro, ma in teoria tutti i pickup dovrebbero utilizzare lo stesso script.
     * Il tipo di pickup viene scelto dai bool attivi.
     * Quindi per esempio, se un pickup dovrebbe sia essere utilizzato come restore del cooldown che come punteggio,
     * il pickup attiva sia lo script del punteggio che lo script del restore del cooldown.
    **/


    /** public bool test; //ovviamente da modificare in futuro con i vari tipi di pickup.
    public Text puntiUI; //ui del testo sullo schermo.
    public int punti; //Questa variabile va spostata nello script che agirà come sistema di punteggio.
    public int puntiRicevuti; //punti ricevuti dal singolo pickup.

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player") && test || other.CompareTag("Onda") && test) {
            this.gameObject.SetActive(false);
            Debug.Log("Enter");
            punti = punti + puntiRicevuti;
            puntiUI.text = "Punti: " + punti;
            }
    } **/
    private void Update() {
      
    }

    protected virtual void Pick() {

    }
}
