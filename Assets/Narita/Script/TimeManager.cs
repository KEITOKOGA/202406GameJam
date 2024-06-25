using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [Header("��������")]
    public float _timer = 10;
    [Header("�\������e�L�X�g")]
    [SerializeField] Text _text;
    [Header("�J�n�܂ł̎���")]
    [SerializeField] float _invokeTime = 1;
    float _changeTimer;
    [Header("���U���g��ʂɈڍs����܂ł̎���")]
    [SerializeField] float _changeTime = 1;
    [Header("�^�C���I�[�o�[���ɗ�����������")]
    [SerializeField] AudioSource _audio;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //�e�L�X�g�\��
        //_text.text = _timer.ToString("F2");
        if (_timer >= 10)
        {
            _text.text = _timer.ToString("F2");
        }
        else
        {
            _text.text = "0" + _timer.ToString("F2");
        }
        //_invokeTime�̕��x�点�Đ������Ԃ̃��\�b�h���Ăяo��
        Invoke(nameof(TimerStart), _invokeTime);
    }
    void TimerStart() //�������Ԃ̃��\�b�h
    {
        _timer -= Time.deltaTime;
        //�^�C�}�[��0�ɂȂ�����0�ɌŒ�
        if (_timer <= 0)
        {
            _text.enabled = false;
            _changeTimer += Time.deltaTime;
            if (_audio != null)
            {
                _audio.Play();
            }
            else if (_audio == null) 
            {
                Debug.LogWarning("AudioSource�ɃA�^�b�`����Ă��܂���");
            }
            if (SceneManagement.IsScene == true && _changeTimer >= _changeTime)
            {
                SceneManagement.SceneChange("Result");
            }
        }
    }
}
