using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check_clear : MonoBehaviour
{
    public GameObject time_slider;

    private void OnControllerColliderHit(ControllerColliderHit hit) {
        if (hit.gameObject.tag=="Clear_area"){
            GameManager.isGameClear = true;
        }    
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag=="smoke")
        time_slider.GetComponent<TimeControl>().speed+=0.5f;
    }
    private void OnTriggerExit(Collider other) {
        if (other.tag=="smoke")
        time_slider.GetComponent<TimeControl>().speed=time_slider.GetComponent<TimeControl>().init_speed;
    }
}
