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
        //transform.DOMoveX(5, 2);                                              //�� ������Ʈ�� 2�ʵ��� X�� 5�� �̵���Ų��
        //transform.DORotate(new Vector3(0, 0, 180), 2);                        //�� ������Ʈ�� 2�ʵ��� z������ 180�� ȸ�� ��Ų��.
        //transform.DOScale(new Vector3(2, 2, 2), 2);                           //�� ������Ʈ�� 2�ʵ��� Scale�� 2�� �ǵ��� Ű���

        //��ü �ּ� �� �ּ� ���� Ctrl + k + c, Ctrl + k + u
        //Sequence sequence = DOTween.Sequence();                               //Tween�� �̾ ������� ���� �����ִ� ����
        //sequence.Append(transform.DOMoveX(5, 2));
        //sequence.Append(transform.DORotate(new Vector3(0, 0, 180), 2));
        //sequence.Append(transform.DOScale(new Vector3(2, 2, 2), 2));
        //transform.DOMoveX(5,2).SetEase(Ease.OutBounce);
        //transform.DOShakeRotation(2f , new Vector3(0, 0, 90), 10, 90);
        //transform.DOMoveX(5, 2).SetEase(Ease.OutBounce).OnComplete(TweenEnd);   //Ʈ���� �Ϸ�Ǹ� Tween End �Լ��� ȣ�� �Ѵ�

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
