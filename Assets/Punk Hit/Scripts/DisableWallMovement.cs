using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableWallMovement : MonoBehaviour {

    private float distanceToWall;
    public bool touchesRWall;
    public bool touchesLWall;
    void Start() {
        distanceToWall = GetComponent<Collider>().bounds.extents.x + 0.1f;
    }

   /** void FixedUpdate() {
        if (Physics.Raycast(transform.position, Vector3.right, hit, distanceToWall) && hit.transform.tag == "Piattaforma"||
            Physics.Raycast(transform.position + new Vector3(0, 0.5f, 0), Vector3.right, hit, distanceToWall) && hit.transform.tag == "Piattaforma" ||
            Physics.Raycast(transform.position + new Vector3(0, -0.5f, 0), Vector3.right, hit, distanceToWall) && hit.transform.tag == "Piattaforma") {
            touchesRWall = true;
        } else touchesRWall = false;

        if (Physics.Raycast(transform.position, -Vector3.right, distanceToWall) || 
            Physics.Raycast(transform.position + new Vector3(0, 0.5f, 0), -Vector3.right, distanceToWall) || 
            Physics.Raycast(transform.position + new Vector3(0, -0.5f, 0), -Vector3.right, distanceToWall)) {
            touchesLWall = true;
        } else touchesLWall = false;
    }**/

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.magenta;
        
        var posL = new Vector3(transform.position.x - distanceToWall, transform.position.y, transform.position.z);
        var posR = new Vector3(transform.position.x + distanceToWall, transform.position.y, transform.position.z);
        Gizmos.DrawLine(posL, posR); 
        posL = new Vector3(transform.position.x - distanceToWall, transform.position.y + 0.5f, transform.position.z);
        posR = new Vector3(transform.position.x + distanceToWall, transform.position.y + 0.5f, transform.position.z);
        Gizmos.DrawLine(posL, posR); 
        posL = new Vector3(transform.position.x - distanceToWall, transform.position.y - .5f, transform.position.z);
        posR = new Vector3(transform.position.x + distanceToWall, transform.position.y - .5f, transform.position.z);
        Gizmos.DrawLine(posL, posR); 
    }
}
