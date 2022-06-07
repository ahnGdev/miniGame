using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//유니티 오브젝트 생명주기
public class LiteCycle4 : MonoBehaviour
{
    

    //Update() 게임 로직 업데이트 - 실행자 환경에따라 실행주기 변화
    void Start() 
    {
        
    }
    void Update()
    {
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal"), 
            Input.GetAxisRaw("Vertical"), 
            0);
        transform.Translate(vec);
    }

}
