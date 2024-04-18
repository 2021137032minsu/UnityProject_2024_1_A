using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExCubePlayer : MonoBehaviour
{
    public Text TextUI = null;
    public int Count = 0;
    public float Power = 100.0f;

    public int Point = 0;
    public float checkTime = 0.0f;

    public Rigidbody m_Rigidbody;

    // Update is called once per frame
    void Update()
    {
        checkTime += Time.deltaTime;                        //�ð��� �����ؼ� �״´�. checkTime -> 0�� , 1�� , 0�� , 1��
        if (checkTime >= 1.0f)                              //1�ʸ��� � �ൿ�� �Ѵ�.
        {
            Point += 1;                                     //1�ʸ��� ���� 1���� �ø���.
            checkTime = 0.0f;                               //�ð��� �ʱ�ȭ �Ѵ�
        }

        if (Input.GetKeyDown(KeyCode.Space))                    //�����̽��� ���� ��
        {
            m_Rigidbody.AddForce(transform.up * Power);     //100 ~ 200 ������ ���� ���� �ش�
            Power = Random.Range(100, 200);           // Y������ ������ ���� �ش�.
        }
        TextUI.text = Point.ToString();
    }
    private void OnCollisionEnter(Collision collision)      //�浹�� �Ǿ�����
    {
        Debug.Log(collision.gameObject.tag);
        if(collision.gameObject.tag == "Pipe")
        {
            Point = 0;
            gameObject.transform.position = Vector3.zero;       //�÷��̾ �������� �̵���Ų��.
        }
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Items")
        {
            Point += 10;
            Destroy(other.gameObject);
        }
    }
}

    
