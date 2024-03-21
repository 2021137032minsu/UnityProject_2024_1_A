using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExCubePlayer : MonoBehaviour
{
    public Text TextUI = null;
    public int Count = 0;
    public float Power = 100.0f;
    public Rigidbody m_Rigidbody;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))                    //�����̽��� ���� ��
        {
            Count += 1;                                     //���콺�� Ŭ���Ǿ����� Count�� 1�� �ø���
            TextUI.text = Count.ToString();                 //UI ����
            m_Rigidbody.AddForce(transform.up * Power);     //100 ~ 200 ������ ���� ���� �ش�
            Power = Random.RandomRange(100, 200);           // Y������ ������ ���� �ش�.
        }
        if(gameObject.transform.position.y >= 2 || gameObject.transform.position.y <= -2)
        {
            TextUI.text = "����";
            Count = 0;
        }
    }
}
