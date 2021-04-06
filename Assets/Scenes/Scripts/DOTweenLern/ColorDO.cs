using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ColorDO : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.DOColor(Color.red, 1).SetLoops(-1, LoopType.Yoyo);
        _spriteRenderer.DOFade(0, 0.5f).SetLoops(-1,LoopType.Yoyo);
        
    }

}
