using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public Slider hPBar;                // slider bar
    public float maxHP = 0.0f;          // 최대 hp
    private float minusHp = 0.0f;       // hp 감소 수치


    // Start is called before the first frame update
    void Start()
    {
        minusHp = 1 / maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        // hp 게이지
        hPBar.value -= minusHp * Time.deltaTime;

    }
}
