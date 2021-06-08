using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateWaves : MonoBehaviour {

    public GameObject soundWaveNormal;
    public GameObject soundWaveHeavy;
    public GameObject soundWaveLight;
    public GameObject soundWaveSpecial;

    public GameObject soundWaveNormalVfx;
    public GameObject soundWaveHeavyVfx;
    public GameObject soundWaveLightVfx;
    public GameObject soundWaveSpecialVfx;

    public float cooldownTime = .8f;

    private bool canShoot = true;
    
    private VariableManager _varMgr;
    void Start()
    {
        _varMgr = FindObjectOfType<VariableManager>();
    }

    void Update()
    {
        GameObject soundWave;
        GameObject soundWaveVfx;
        switch (_varMgr.GetSelectedGuitar())
        {
            case GuitarTypes.Leggera:
                soundWave = soundWaveLight;
                soundWaveVfx = soundWaveLightVfx;
                break;
            case GuitarTypes.Pesante:
                soundWave = soundWaveHeavy;
                soundWaveVfx = soundWaveHeavyVfx;
                break;
            case GuitarTypes.OP:
                soundWave = soundWaveSpecial;
                soundWaveVfx = soundWaveSpecialVfx;
                break;
            default:
                soundWave = soundWaveNormal;
                soundWaveVfx = soundWaveNormalVfx;
                break;
        }
        
        if (Input.GetButtonDown("Fire1") && canShoot)
        {
            canShoot = false;
            GameObject ondaSonora = Instantiate(soundWave, transform.position, transform.rotation);
            GameObject ondaSonoraVfx = Instantiate(soundWaveVfx, transform.position, transform.rotation);
            Invoke("ReactivateGuitar", cooldownTime);
        }
    }

    private void ReactivateGuitar()
    {
        canShoot = true;
    }
}
