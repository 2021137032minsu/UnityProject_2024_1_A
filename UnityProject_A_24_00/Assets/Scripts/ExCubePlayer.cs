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
        if (Input.GetKeyDown(KeyCode.Space))                    //스페이스를 누를 때
        {
            Count += 1;                                     //마우스가 클릭되었을때 Count를 1씩 올린다
            TextUI.text = Count.ToString();                 //UI 갱신
            m_Rigidbody.AddForce(transform.up * Power);     //100 ~ 200 사이의 값의 힘을 준다
            Power = Random.RandomRange(100, 200);           // Y축으로 설정한 힘을 준다.
        }
        if(gameObject.transform.position.y >= 2 || gameObject.transform.position.y <= -2)
        {
            TextUI.text = "실패";
            Count = 0;
        }
    }
}
