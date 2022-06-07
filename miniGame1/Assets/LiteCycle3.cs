using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//유니티 오브젝트 생명주기
public class LiteCycle3 : MonoBehaviour
{
    

    //Update() 게임 로직 업데이트 - 실행자 환경에따라 실행주기 변화
    void Update() 
    {
        /*
        if (Input.anyKeyDown) {
            Debug.Log("키누름");
        }
        if (Input.anyKey)
        {
            Debug.Log("키누름ing");
        }
        

        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("아이템 구매");
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("왼쪽 방향키1");
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Debug.Log("오른쪽 방향키에서 손 땜");
        }
        */
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("미사일 발사!");
        }
        if (Input.GetMouseButton(0))
        {
            Debug.Log("미사일 모으기(누른는중)!");
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("미사일 발사!!!(버튼땜)");
        }

    }


}
