using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public Transform fireHole;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * v * Time.deltaTime * 2f);
        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * 2f);

        Debug.DrawRay(fireHole.position, fireHole.forward * 30f, Color.green);
    }
}
