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
        //2.SmoothDamp(0,0,0,�������� ����)
        Vector3 velo = Vector3.zero;

        transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 1);
        //3.Lerp =(0,0,�������� ����) SmoothDamp���� ������ ��/SLerp ������ �̵� 
        

        //
        transform.position = Vector3.Slerp(transform.position, target, 0.01f);
        
        transform.position = Vector3.MoveTowards(transform.position, target, 1f);

        // ���� ������Ʈ �������� �̵�
        transform.Translate(Vector3.right * Time.deltaTime);

        // ���� ��ǥ �������� �̵�
        transform.Translate(Vector3.forward * Time.deltaTime, Space.World);
        */

        ///////////////////////////////////////////////////////////////////////////////


        //���� ����ġ���� �߻� 
        transform.Translate(Vector3.right * 0.01f);
        //�����ð�? �Ÿ�? �̵��� ��ġ�ʱ�ȭ�ʿ�
        //a���� b������ �Ÿ�
        //float distance = Vector3.Distance(a, b);
        float distance = Vector3.Distance(startLocation, transform.position);
        //Debug.Log("��ġ" + distance);
        if (distance > 50)
        {
            //Debug.Log("��ġ����!!!!"+ startLocation);
            transform.position = startLocation;
        }
        
    }

}
