using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Vector3 startLocation;
    void Awake()
    {
        startLocation = transform.position;
    }




    /*
    Vector3 target = new Vector3(10, 3f, 0);
    */
    void Update()
    {   /*
        //1.MoveTowards 
        //transform.position = Vector3.MoveTowards(transform.position, target, 1f);
        //2.SmoothDamp(0,0,0,작을수록 빠름)
        Vector3 velo = Vector3.zero;

        transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 1);
        //3.Lerp =(0,0,작을수록 느림) SmoothDamp보다 감속이 김/SLerp 포물선 이동 
        

        //
        transform.position = Vector3.Slerp(transform.position, target, 0.01f);
        
        transform.position = Vector3.MoveTowards(transform.position, target, 1f);

        // 게임 오브젝트 기준으로 이동
        transform.Translate(Vector3.right * Time.deltaTime);

        // 절대 좌표 기준으로 이동
        transform.Translate(Vector3.forward * Time.deltaTime, Space.World);
        */

        ///////////////////////////////////////////////////////////////////////////////


        //로켓 현위치에서 발사 
        transform.Translate(Vector3.right * 0.01f);
        //일정시간? 거리? 이동후 위치초기화필요
        //a에서 b까지의 거리
        //float distance = Vector3.Distance(a, b);
        float distance = Vector3.Distance(startLocation, transform.position);
        //Debug.Log("위치" + distance);
        if (distance > 50)
        {
            //Debug.Log("위치변경!!!!"+ startLocation);
            transform.position = startLocation;
        }
        
    }

}
