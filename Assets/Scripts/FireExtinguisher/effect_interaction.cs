using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effect_interaction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnParticleCollision(GameObject other) {
        if (other.tag=="fire")
        {
            if (GameManager.fireType != GameManager.fireExtinguisherType)
            {
                GameManager.isGameOver = true;
            }
            else
            {
                other.GetComponent<FireHP>().fire_hp -=1 ;
            }
        }
    }
}
