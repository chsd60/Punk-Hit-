using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateWaves : MonoBehaviour {

    public GameObject soundWaveNormal;
    public GameObject soundWaveHeavy;
    public GameObject soundWaveLight;
    public GameObject soundWaveSpecial;
    public float speed;

    private VariableManager _varMgr;
    void Start()
    {
        _varMgr = FindObjectOfType<VariableManager>();
    }

    void Update()
    {
        GameObject soundWave;
        switch (_varMgr.GetSelectedGuitar())
        {
            case GuitarTypes.Leggera:
                soundWave = soundWaveLight;
                break;
            case GuitarTypes.Pesante:
                soundWave = soundWaveHeavy;
                break;
            case GuitarTypes.OP:
                soundWave = soundWaveSpecial;
                break;
            default:
                soundWave = soundWaveNormal;
                break;
        }
        
        if (Input.GetButtonDown("Fire1")) {
            GameObject ondaSonora = Instantiate(soundWave, transform.position, transform.rotation);
            ondaSonora.GetComponent<Rigidbody>().AddRelativeForce(speed, 0, 0);
        }
    }
}
