using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//����Ƽ ������Ʈ �����ֱ�
public class LiteCycle4 : MonoBehaviour
{
    

    //Update() ���� ���� ������Ʈ - ������ ȯ�濡���� �����ֱ� ��ȭ
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
