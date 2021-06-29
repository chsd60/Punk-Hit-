using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject player;

    public Transform checkPoint;
    
    void Start()
    {
        if (checkPoint == null) FindObjectOfType<CheckPoint>();
        player = GameObject.FindWithTag("Player");
        SetPlayerPosition();
    }

    public void SetPlayerPosition()
    {
        player.transform.position = checkPoint.transform.position;
    }

    public void UpdateCheckPoint(Transform point)
    {
        checkPoint = point;
    }
}
