using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireExtinguisherInteractions : MonoBehaviour
{
    public GameObject menu;
    public GameObject pin;
    public GameObject hose1;
    public GameObject hose2;
    public GameObject effect;
    //ParticleSystem ps = effect.GetComponent<ParticleSystem>();

    Animator animator;

    private void Awake() {
        animator = gameObject.GetComponent<Animator>();
    }


    public void ActivateMenu() // On Hover Entered
    {
        if (!GameManager.isSelected)
        {
            menu.SetActive(true);
        }   
    }

    public void RemovePin() // On Activate
    {
        //Animator animator = gameObject.GetComponent<Animator>();

        if (GameManager.isSelected)
        {
            if (!GameManager.isPinRemoved) 
            {
                animator.SetBool("pin",true);

                StartCoroutine(chage_hose_1());

                GameManager.isPinRemoved = true;
            }
        }
    }

    public void Fire() // On Select Entered
    {
        if (GameManager.isPinRemoved)
        {
            if (effect.activeInHierarchy==false)
            {
                effect.SetActive(true);
            }
            else
            {
                ParticleSystem ps = effect.GetComponent<ParticleSystem>();
                ps.Play();
            }
        }
    }

    public void hose_change()
    {
        hose1.SetActive(true);
        hose2.SetActive(false);
    }

    public void hose_change_2()
    {
        if (GameManager.isPinRemoved){
            hose1.SetActive(false);
            hose2.SetActive(true);
        }
    }

    public void on_lever()
    {
        if (GameManager.isPinRemoved){
            animator.SetBool("lever",true);
        }
    }

    public void off_lever()
    {
        if (GameManager.isPinRemoved){
            animator.SetBool("lever",false);
        }
    }

    public void StopEffect()
    {
        ParticleSystem ps = effect.GetComponent<ParticleSystem>();
        ps.Stop();
    }

    IEnumerator chage_hose_1(){
        yield return new WaitForSeconds(2);
        hose1.SetActive(false);
        hose2.SetActive(true);
    }
}
