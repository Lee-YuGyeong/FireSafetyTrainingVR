using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestData : MonoBehaviour
{
    public string questName;
    public int[] UI_Id;

    //생성자
    public QuestData(string name, int[] UI_Num)
    {
        questName=name;
        UI_Id=UI_Num;
    }
}
