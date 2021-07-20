using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireHP : MonoBehaviour
{
    public int fire_hp=10;
    public GameObject effect_1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        fire_off();
    }

    public void fire_off(){
        ParticleSystem ps = effect_1.GetComponent<ParticleSystem>();

        //ps.Stop();

        if (fire_hp==0){
            ps.Stop();
            
            StartCoroutine(fire_off_c());
        }
    }

    IEnumerator fire_off_c(){
        yield return new WaitForSeconds(2);
        gameObject.SetActive(false);
    }



    /*int fireLife = 10;

   private void OnParticleCollision(GameObject other)
   {
       /*if (fireLife > 0 && other.tag.CompareTo("extinguisher") == 0)
       {
           fireLife--;
           if (fireLife <= 0)
           {
               ParticleSystem ps = transform.GetComponent<ParticleSystem>();
               ps.Stop(true);
           }
       }

       ParticleSystem ps = transform.GetComponent<ParticleSystem>();
       ps.Stop(true);
   }
   */
}
