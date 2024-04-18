using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenTest : MonoBehaviour
{
    Sequence sequence;
    Tween tween;
    // Start is called before the first frame update
    void Start()
    {
        //transform.DOMoveX(5, 2);                                              //이 오브젝트를 2초동안 X축 5로 이동시킨다
        //transform.DORotate(new Vector3(0, 0, 180), 2);                        //이 오브젝트를 2초동안 z축으로 180도 회전 시킨다.
        //transform.DOScale(new Vector3(2, 2, 2), 2);                           //이 오브젝트를 2초동안 Scale이 2가 되도록 키운다

        //전체 주석 및 주석 해제 Ctrl + k + c, Ctrl + k + u
        //Sequence sequence = DOTween.Sequence();                               //Tween을 이어서 순서대로 실행 시켜주는 단위
        //sequence.Append(transform.DOMoveX(5, 2));
        //sequence.Append(transform.DORotate(new Vector3(0, 0, 180), 2));
        //sequence.Append(transform.DOScale(new Vector3(2, 2, 2), 2));
        //transform.DOMoveX(5,2).SetEase(Ease.OutBounce);
        //transform.DOShakeRotation(2f , new Vector3(0, 0, 90), 10, 90);
        //transform.DOMoveX(5, 2).SetEase(Ease.OutBounce).OnComplete(TweenEnd);   //트윈이 완료되면 Tween End 함수를 호출 한다

        sequence = DOTween.Sequence();
        sequence.Append(transform.DOMoveX(5, 1));
        sequence.SetLoops(-1, LoopType.Yoyo);

    }

    void TweenEnd()
    {
        gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sequence.Kill();
        }
    }
}
