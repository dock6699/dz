using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class firstMove : MonoBehaviour
{
    [SerializeField] GameObject _targetPoint;

    void Start()
    {
        transform.DOMove(_targetPoint.transform.position, 3).SetLoops(-1,LoopType.Yoyo);
    }
}
