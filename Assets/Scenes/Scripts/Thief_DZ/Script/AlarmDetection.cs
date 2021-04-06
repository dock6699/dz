using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AlarmDetection : MonoBehaviour
{
    private AudioSource _alarmSignalSource;

    private float _duration;
    private float _runningTime;
    private float _targetVolume;
    private float _currentVolume;

    private void Start()
    {
        
        if(GetComponent<AudioSource>())
        {
            _alarmSignalSource = GetComponent<AudioSource>();
            _alarmSignalSource.volume = 0;
            _targetVolume = 1;
            _duration = _alarmSignalSource.clip.length / 2;
        }
    }

    private void Update()
    {
        if (_alarmSignalSource.isPlaying)
        {
            if (_runningTime <= _duration)
            {
                _runningTime += Time.deltaTime;
                float normalizedTime = _runningTime / _duration;

                _alarmSignalSource.volume = Mathf.MoveTowards(_currentVolume, _targetVolume, normalizedTime);
            }
            else
            {
                _targetVolume *= -1;
                _runningTime = 0;
                _currentVolume = _alarmSignalSource.volume;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Thief>()!= null)
        {
            _alarmSignalSource.Play();
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Thief>() != null)
        {

            _alarmSignalSource.Stop();
            _runningTime = 0;
        }
    }
}
