using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideScript : MonoBehaviour
{
    public Slider sliderA;

    int hp;
    int hpFull;

    // Start is called before the first frame update
    void Awake()
    {
        hp = 100;
        hpFull = 100;
    }

    // Update is called once per frame
    void Update()
    {
        sliderA.value = (float)hp / hpFull;   
    }

    public void OnclickButtonA()
    {
        hp = hp - 1;
    }
}
