using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] Text _timerText;
    [SerializeField] AudioSource _audioSource;
    [SerializeField] AudioSource _beep;
    [SerializeField] GameObject _bombBoom;
    float _timer = 10;
    [SerializeField]float _interval = 0;
    private void Update()
    {
        _timer -= Time.deltaTime;
        _interval += Time.deltaTime;
        if( _timer < 10 )
        {
            _timerText.text = "0" + _timer.ToString("F2");
        }
        else
        {
            _timerText.text = _timer.ToString("F2");
        }
        if(_interval >= 1)
        {
            //if( _timer <= 1.5f )
            //{
            //    _beep.Play();
            //}
            _interval = 0;
            _audioSource.Play();
        }
        if( _timer <= 0 )
        {
            _timerText.text = "00.00";
            Instantiate(_bombBoom, transform);
        }
    }
}
