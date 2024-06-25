using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimerManager : MonoBehaviour
{
    [Header("�^�C�}�[")]
    [SerializeField] float _timer;
    [Header("�e�L�X�g")]
    [SerializeField] Text _text;
    [Header("�n�܂�܂ł̎���")]
    [SerializeField] float _invokeTime;
    [Header("�t�F�[�h����C���^�[�o��")]
    [SerializeField] float _interval;
    [Header("�t�F�[�h���鎞�ɏo��C���[�W")]
    [SerializeField] Image _fadePanel = default;
    [Header("�t�F�[�h���I���܂ł̎���")]
    [SerializeField] int _EndFadeMode;
    [Header("�^�C�}�[�̉�")]
    [SerializeField] AudioSource _timerAudio;
    [Header("�^�C�}�[�̉��̊Ԋu")]
    [SerializeField] int _timerInterval = 1;
    int _pulusTimer = 1;
    [Header("�^�C���A�b�v�ŏo����������")]
    [SerializeField] GameObject _audioObject;
    [SerializeField] GameObject _explosionObject;
    [Header("�^�C���A�^�b�N���U���g�V�[��")]
    [SerializeField] string _sceneResult;
    [Header("�G���h���X���U���g�V�[��")]
    [SerializeField] string _sceneResultEnd;

    void Start()
    {
        SceneManagement.IsInGame = false;
        // �C���^�[�o���̃J�E���g�_�E�����J�n
        StartCoroutine(IntervalCoroutine());
    }

    void Update()
    {
        // �^�C�}�[�\��
        if (_invokeTime <= 0) // �C���^�[�o�����I��������^�C�}�[�\�����X�V
        {
            _text.text = (_timer >= 10) ? _timer.ToString("F2") : "0" + _timer.ToString("F2");
        }
    }

    IEnumerator IntervalCoroutine()
    {
        float intervalTime = _invokeTime;
        while (intervalTime > 0)
        {
            _text.text = intervalTime.ToString("F0"); // �C���^�[�o�����Ԃ̕\��
            _text.DOColor(Color.red, 1).OnComplete(() => _text.DOColor(Color.white, 1));
            intervalTime -= Time.deltaTime;
            yield return null;
        }

        // �C���^�[�o���I�����̕\��
        _invokeTime = 0; // �C���^�[�o���I�����������߂ɐݒ�
        StartCoroutine(TimerCoroutine()); // �^�C�}�[�̃J�E���g�_�E�����J�n
    }

    IEnumerator TimerCoroutine()
    {
        while (_timer > 0)
        {
            _timer -= Time.deltaTime;
            yield return null;
            if (_timer <= _timerInterval && _timer >= .5)
            {
                if (_timerAudio != null)
                {
                    _timerAudio.Play();
                    _timerInterval -= _pulusTimer;
                }
                else
                {
                    Debug.LogWarning("Audio��null���");
                }
            }
        }

        // �^�C�}�[��0�ɂȂ�����0�ɌŒ�
        _timer = 0;
        _text.enabled = false;
        if (SceneManagement.IsScene == true)
        {
            _fadePanel.gameObject.SetActive(true);
            Instantiate(_audioObject, transform.position, Quaternion.identity);
            Instantiate(_explosionObject, transform.position, Quaternion.identity);
            _fadePanel.material.DOFade(_EndFadeMode, _interval).OnComplete(() => SceneManagement.SceneChange(_sceneResult));
        }
        else if (SceneManagement.IsScene == false)
        {
            _fadePanel.gameObject.SetActive(true);
            Instantiate(_audioObject, transform.position, Quaternion.identity);
            Instantiate(_explosionObject, transform.position, Quaternion.identity);
            _fadePanel.material.DOFade(_EndFadeMode, _interval).OnComplete(() => SceneManagement.SceneChange(_sceneResultEnd));
        }
    }
}
