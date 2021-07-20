using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR.Interaction.Toolkit;

public class onClick_fireExtinguisher : MonoBehaviour
{
    public GameObject FireExtinguisherMenu;

    public void button_A_clicked()
    {
        GameManager.fireExtinguisherType = 1;
        GameManager.isSelected = true;
        FireExtinguisherMenu.SetActive(false);
    }
    public void button_B_clicked()
    {
        GameManager.fireExtinguisherType = 2;
        GameManager.isSelected = true;
        FireExtinguisherMenu.SetActive(false);
    }
    public void button_C_clicked()
    {
        GameManager.fireExtinguisherType = 3;
        GameManager.isSelected = true;
        FireExtinguisherMenu.SetActive(false);
    }
}
