using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;


public class GameManager : MonoBehaviour
{
    public static GameManager instance; 

    public static int fireType;    // 화재 상황 종류 1 : 일반화재, 2 : 알콜화재, 3 : 전기화재
    public static int fireExtinguisherType;    // 소화기 종류

    private Text Quest;    // 스크린에 있는 텍스트
    public GameObject fireAlertUI;   // 스크린에 있는 UI
    public GameObject gameoverUI;    // 게임 오버 UI
    public GameObject gameclearUI;    // 게임 클리어 UI
    public GameObject gameUI;
    public GameObject fireButtonUI;
    public GameObject evacuateUI;      // 대피 UI

    public static bool isSelected = false;  // 소화기 종류 선택했는지 여부
    public static bool isPinRemoved = false;   // 소화기 안전핀 제거했는지 여부
    public static bool isGameOver = false;  // 게임 오버 여부
    public static bool isGameClear = false;  // 게임 클리어 여부

    public GameObject fire1;
    public GameObject fire2;

    public GameObject leftHand;
    public GameObject rightHand;

    public GameObject fireExtinguisher;

    
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        Quest = fireAlertUI.GetComponent<Text>();
        randomFire();   // 랜덤 화재 발생
    }

    void Update()
    {
        if (isGameOver)
        {
            GameOver();
        }
        if (isGameClear)
        {
            GameClear();
        }
        if ((fire1.activeInHierarchy == false) && (fire2.activeInHierarchy == false))
        {
            evacuateUI.SetActive(true);
        }

        ray_OnOff();
    }

    void ray_OnOff()
    {
        if (gameclearUI.activeInHierarchy==true||gameoverUI.activeInHierarchy==true||fireButtonUI.activeInHierarchy==true){
            leftHand.GetComponent<XRInteractorLineVisual>().enabled=true;
            rightHand.GetComponent<XRInteractorLineVisual>().enabled=true;
        }
        else{
            leftHand.GetComponent<XRInteractorLineVisual>().enabled=false;
            rightHand.GetComponent<XRInteractorLineVisual>().enabled=false;
        }
    }

    void randomFire()
    {
        fireType = Random.Range(1, 4); 

        switch(fireType)
        {
            case 1:
                Quest.text = "불씨가 튀어 불이 났습니다.\n불을 끌만한 것을 찾아보세요!";
                break;
            case 2:
                Quest.text = "알코올램프에서 불이 났습니다.\n불을 끌만한 것을 찾아보세요!";
                break;
            case 3:
                Quest.text = "콘센트에서 불이 났습니다.\n불을 끌만한 것을 찾아보세요!";
                break;
        }
    }

    public void GameOver()
    {
        fireExtinguisher.SetActive(false);
        gameoverUI.SetActive(true);
        gameUI.SetActive(false);
        Time.timeScale = 0;
    }

    public void GameClear()
    {
        gameclearUI.SetActive(true);
        gameUI.SetActive(false);
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        isGameOver = false;
        isSelected = false;
        isPinRemoved = false; 
        isGameClear=false;

        fireExtinguisher.SetActive(true);
        
        gameUI.SetActive(true);
        SceneManager.LoadScene("main_1");
        Time.timeScale = 1f;
    }
}
