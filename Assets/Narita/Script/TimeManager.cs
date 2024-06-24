using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [Header("��������")]
    public float _timer = 10;
    [Header("�\������e�L�X�g")]
    [SerializeField] Text _text;
    [Header("�J�n�܂ł̎���")]
    [SerializeField] float _invokeTime = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //�e�L�X�g�\��
        _text.text = _timer.ToString("F2");
        //_invokeTime�̕��x�点�Đ������Ԃ̃��\�b�h���Ăяo��
        Invoke(nameof(TimerStart),_invokeTime);
    }
    void TimerStart() //�������Ԃ̃��\�b�h
    {
        _timer -= Time.deltaTime;
        //�^�C�}�[��0�ɂȂ�����0�ɌŒ�
        if (_timer <= 0)
        {
            _text.enabled = false;
        }
    }
}