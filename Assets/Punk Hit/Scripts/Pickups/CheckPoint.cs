using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CheckPoint : PickupBase
{
    private SpawnManager _sm;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Collider>().isTrigger = true;
        _sm = FindObjectOfType<SpawnManager>();
    }

    protected override void Pick()
    {
        _sm.UpdateCheckPoint(transform);
        if (spawnedPrefab != null)
        {
            Instantiate(spawnedPrefab, transform.position, transform.rotation);
        }
    }
}
