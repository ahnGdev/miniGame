using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//����Ƽ ������Ʈ �����ֱ�
public class LiteCycle3 : MonoBehaviour
{
    

    //Update() ���� ���� ������Ʈ - ������ ȯ�濡���� �����ֱ� ��ȭ
    void Update() 
    {
        /*
        if (Input.anyKeyDown) {
            Debug.Log("Ű����");
        }
        if (Input.anyKey)
        {
            Debug.Log("Ű����ing");
        }
        

        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("������ ����");
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("���� ����Ű1");
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Debug.Log("������ ����Ű���� �� ��");
        }
        */
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("�̻��� �߻�!");
        }
        if (Input.GetMouseButton(0))
        {
            Debug.Log("�̻��� ������(��������)!");
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("�̻��� �߻�!!!(��ư��)");
        }

    }


}
