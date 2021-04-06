﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearColorChanger : MonoBehaviour
{
    [HideInInspector] public SpriteRenderer Target;
    [SerializeField] private float _duration;

    [SerializeField] private Color _targetColor;
    private float _runningTime;
    private Color _startColor;

    void Start()
    {
        Target = GetComponent<SpriteRenderer>();
        _startColor = Target.color;
    }

    // Update is called once per frame
    void Update()
    {
     
        if(_runningTime <= _duration)
        {
            _runningTime += Time.deltaTime;
            float normalizeRunningTime = _runningTime / _duration;

            Target.color = Color.Lerp(_startColor, _targetColor, normalizeRunningTime);
        }
    }
}
