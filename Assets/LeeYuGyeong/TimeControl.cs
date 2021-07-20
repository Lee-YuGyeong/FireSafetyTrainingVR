using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeControl : MonoBehaviour
{
    public GameObject gameobject;
    public float total_time=120;
    public float speed;
    public float init_speed;
    public GameObject spreadingFire1;
    public GameObject spreadingFire2;
    public GameObject spreadingFire3;

    // Start is called before the first frame update
    void Start()
    {
        init_speed = speed = (float)gameobject.transform.localScale.x / total_time;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.localScale.x <= 0)
        {
            Debug.Log(transform.localScale.x + "타임오버");
            GameManager.isGameOver=true;
        }
        else{
            transform.localScale = new Vector3
            (transform.localScale.x - 1f * Time.deltaTime * speed, 1, 1);

            if(transform.localScale.x/speed >110){
            }
            else if (transform.localScale.x/speed >100)
            {
            spreadingFire1.SetActive(true);
            }
            else if (transform.localScale.x/speed >= 90)
            {
            spreadingFire2.SetActive(true);
            }
            else
            {
            spreadingFire3.SetActive(true);
            }
        }
    }
}
