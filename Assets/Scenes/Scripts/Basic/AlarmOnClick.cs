﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmOnClick : MonoBehaviour
{
    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }


    private void OnMouseDown()
    {
        _animator.SetTrigger("Alarm");
    }
}
