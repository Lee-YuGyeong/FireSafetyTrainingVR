using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class OnAnimation_door : MonoBehaviour
{
    public void door_animation(){
        Animator animator = gameObject.GetComponent<Animator>();

        animator.SetBool("click",true);
    }
}
