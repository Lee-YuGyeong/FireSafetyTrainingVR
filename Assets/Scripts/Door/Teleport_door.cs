using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_door : MonoBehaviour
{
    //public Transform teleportTarget;
    public GameObject teleport_position;
    public GameObject xrRig;

    public void door_teleport()
    {   
        xrRig.transform.position=teleport_position.transform.position;
        xrRig.transform.rotation=teleport_position.transform.rotation;

        //xrRig.transform.position = teleportTarget.transform.position;
    }
}
