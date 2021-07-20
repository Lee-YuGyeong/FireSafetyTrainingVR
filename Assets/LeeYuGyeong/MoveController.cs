using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    private float h = 0.0f; //좌우 이동 변수
    private float v = 0.0f; //전후 이동 변수
    private float r = 0.0f; //회전 속도 변수
    private Transform tr; //Transform 변수
    public float moveSpeed = 10.0f; //이동 속도 변수
    public float rotSpeed = 80.0f; //회전 속도 변수


    // Start is called before the first frame update
    void Start()
    {
        //스크립트가 실행된 후 처음 수행되는 Start 함수에서 Transform 컴포넌트를 할당
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal"); //Input 매니저에서 키보드 좌우 입력값 받아오기
        v = Input.GetAxis("Vertical"); //Input 매니저에서 키보드 전후 입력값 받아오기
        r = Input.GetAxis("Mouse X"); //Input 매니저에서 마우스 좌우 입력값 받아오기
        //Debug.Log("H=" + h.ToString());
        //Debug.Log("V=" + v.ToString());

        //전후좌우 이동 방향 벡터 계산
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);

        //Translate(이동방향 * 속도 * 변위값 * Time.deltaTime, 기준좌표)
        tr.Translate(moveDir * moveSpeed * Time.deltaTime, Space.Self);

        //Vector3.up 축을 기준으로 rotSpeed 만큼의 속도로 회전
        tr.Rotate(Vector3.up * rotSpeed * Time.deltaTime * r);


      

    }
}
