using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//유니티 오브젝트 생명주기
public class LiteCycle : MonoBehaviour
{
    //Awake() 게임 오브젝트 생성시, 최초 실행,한 번만 실행
    void Awake()
    {
        Debug.Log("플레이어 데이터 준비완료");
    }

    //OnEnable() 오브젝트 활성화,객체 등장 시,등장마다
    void OnEnable()
    {
        Debug.Log("객체 등장 시 OnEnable");
    }

    //Start() 업데이트 시작 직전, 최초 실행,한 번만 실행
    void Start()
    {
        Debug.Log("사냥  준비완료");
    }
    //Awake(),Start() 초기화 영역



    //FixedUpdate() 물리 연산 업데이트- 1초에 여러번 작동(cpu 많이 사용)-보통50회
    void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    //Update() 게임 로직 업데이트 - 실행자 환경에따라 실행주기 변화
    void Update()
    {
        Debug.Log("Update");
    }

    //LateUpdate() 모든 업데이트 끝난후 -카메라 후처리
    void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }
    //FixedUpdate(),Update(),LateUpdate() 프레임 영역

    //OnDisable() 오브젝트 활성화,객체 사라짐
    void OnDisable()
    {
        Debug.Log("객체 사라짐 OnDisable");
    }

    //OnDestroy-오브젝트 삭제시 작동
    void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }



}
