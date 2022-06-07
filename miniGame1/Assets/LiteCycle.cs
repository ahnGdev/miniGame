using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//����Ƽ ������Ʈ �����ֱ�
public class LiteCycle : MonoBehaviour
{
    //Awake() ���� ������Ʈ ������, ���� ����,�� ���� ����
    void Awake()
    {
        Debug.Log("�÷��̾� ������ �غ�Ϸ�");
    }

    //OnEnable() ������Ʈ Ȱ��ȭ,��ü ���� ��,���帶��
    void OnEnable()
    {
        Debug.Log("��ü ���� �� OnEnable");
    }

    //Start() ������Ʈ ���� ����, ���� ����,�� ���� ����
    void Start()
    {
        Debug.Log("���  �غ�Ϸ�");
    }
    //Awake(),Start() �ʱ�ȭ ����



    //FixedUpdate() ���� ���� ������Ʈ- 1�ʿ� ������ �۵�(cpu ���� ���)-����50ȸ
    void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    //Update() ���� ���� ������Ʈ - ������ ȯ�濡���� �����ֱ� ��ȭ
    void Update()
    {
        Debug.Log("Update");
    }

    //LateUpdate() ��� ������Ʈ ������ -ī�޶� ��ó��
    void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }
    //FixedUpdate(),Update(),LateUpdate() ������ ����

    //OnDisable() ������Ʈ Ȱ��ȭ,��ü �����
    void OnDisable()
    {
        Debug.Log("��ü ����� OnDisable");
    }

    //OnDestroy-������Ʈ ������ �۵�
    void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }



}
