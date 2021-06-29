using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    public float destroyTime = .5f;
    
    void Start()
    {
        Invoke("DelayedDestroy", destroyTime);
    }

    private void DelayedDestroy()
    {
        Destroy(gameObject);
    }
}
