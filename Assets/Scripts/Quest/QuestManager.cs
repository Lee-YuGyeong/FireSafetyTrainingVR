using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public int questId;
    public int questActionIndex;
    public GameObject[] questObject; //우린 게임 오브젝트에서 UI로 바꿔야함
 
    Dictionary<int, QuestData> questList;
 
    void Start()
    {
        questList = new Dictionary<int, QuestData>();
        GenerataData();
    }
 
    void GenerataData()
    {
        questList.Add(10, new QuestData("소화기로 불 끄기", new int[] { 1000}));
        questList.Add(20, new QuestData("과학실 밖으로 탈출하기", new int[] { 2000 }));
        questList.Add(30, new QuestData("건물 밖으로 탈출하기", new int[] { 3000 }));
        questList.Add(40, new QuestData("소방차를 기다리기", new int[] { 4000 }));
        questList.Add(50, new QuestData("퀘스트 올 클리어", new int[] { 0 }));
    }

    //퀘스트 성공하면 다음 퀘스트로
    void NextQuest()
    {
        questId += 10;
        questActionIndex = 0;
    }

    //퀘스트 ID에 맞춰 UI 컨트롤(보이고 안보이고)
    void ControlObject()
    {
        switch (questId)
        {
            case 10:
                if (questActionIndex == 2)
                    questObject[0].SetActive(true);
                break;
            case 20:
                if (questActionIndex == 1)
                    questObject[0].SetActive(false);
                break;
        }
    }
 
    public int GetQuestIndex(int id)
    {
        return questId + questActionIndex;
    }

    public string CheckQuest(int id)
    {
        if (id == questList[questId].UI_Id[questActionIndex])
        {
            questActionIndex++;
        }
 
        ControlObject();
 
        if (questActionIndex == questList[questId].UI_Id.Length)
        {
            NextQuest();
            Debug.Log(questId);
        }
 
        return questList[questId].questName;
    }
 
    public string CheckQuest()
    {
        return questList[questId].questName;
    }
}
