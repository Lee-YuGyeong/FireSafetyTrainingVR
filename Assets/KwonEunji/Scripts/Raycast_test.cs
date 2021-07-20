using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast_test : MonoBehaviour
{
    void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.red);

        RaycastHit hit;

		if(Physics.Raycast(transform.position , forward, out hit , 10))
        {
			Debug.Log ( hit.collider.gameObject.name );
			// 광선이 충돌한 오브젝트를 로그창에 보여 준다.

            if (Input.GetMouseButtonDown(0)){
                if (hit.collider.gameObject.name=="Door"){
                    Animator animator = hit.collider.gameObject.GetComponent<Animator>();

                    animator.SetBool("click",true);
                    gameObject.GetComponent<moveObject>().enabled=false;
                }
            }
		}
    }
}
