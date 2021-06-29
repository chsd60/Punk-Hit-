using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject player;

    public Transform checkPoint;
    
    void Start()
    {
        if (checkPoint == null) checkPoint = FindObjectOfType<CheckPoint>().transform;
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
