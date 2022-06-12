using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacter : MonoBehaviour
{

    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {

            Debug.Log("Å°´©¸§");
            rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
        }
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
        rigid.AddForce(vec, ForceMode.Impulse);

       
    }
}
