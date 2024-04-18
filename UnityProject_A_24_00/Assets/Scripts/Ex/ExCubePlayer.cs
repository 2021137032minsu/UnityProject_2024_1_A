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
        checkTime += Time.deltaTime;                        //시간을 누적해서 쌓는다. checkTime -> 0초 , 1초 , 0초 , 1초
        if (checkTime >= 1.0f)                              //1초마다 어떤 행동을 한다.
        {
            Point += 1;                                     //1초마다 점수 1점을 올린다.
            checkTime = 0.0f;                               //시간을 초기화 한다
        }

        if (Input.GetKeyDown(KeyCode.Space))                    //스페이스를 누를 때
        {
            m_Rigidbody.AddForce(transform.up * Power);     //100 ~ 200 사이의 값의 힘을 준다
            Power = Random.Range(100, 200);           // Y축으로 설정한 힘을 준다.
        }
        TextUI.text = Point.ToString();
    }
    private void OnCollisionEnter(Collision collision)      //충돌이 되었을때
    {
        Debug.Log(collision.gameObject.tag);
        if(collision.gameObject.tag == "Pipe")
        {
            Point = 0;
            gameObject.transform.position = Vector3.zero;       //플레이어를 원점으로 이동시킨다.
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

    
