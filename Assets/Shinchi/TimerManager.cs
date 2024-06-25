using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimerManager : MonoBehaviour
{
    [Header("タイマー")]
    [SerializeField] float _timer;
    [Header("テキスト")]
    [SerializeField] Text _text;
    [Header("始まるまでの時間")]
    [SerializeField] float _invokeTime;
    [Header("フェードするインターバル")]
    [SerializeField] float _interval;
    [Header("フェードする時に出るイメージ")]
    [SerializeField] Image _fadePanel = default;
    [Header("フェードが終わるまでの時間")]
    [SerializeField] int _EndFadeMode;
    [Header("タイマーの音")]
    [SerializeField] AudioSource _timerAudio;
    [Header("タイマーの音の間隔")]
    [SerializeField] int _timerInterval = 1;
    int _pulusTimer = 1;
    [Header("タイムアップで出したいもの")]
    [SerializeField] GameObject _audioObject;
    [SerializeField] GameObject _explosionObject;
    [Header("タイムアタックリザルトシーン")]
    [SerializeField] string _sceneResult;
    [Header("エンドレスリザルトシーン")]
    [SerializeField] string _sceneResultEnd;

    void Start()
    {
        SceneManagement.IsInGame = false;
        // インターバルのカウントダウンを開始
        StartCoroutine(IntervalCoroutine());
    }

    void Update()
    {
        // タイマー表示
        if (_invokeTime <= 0) // インターバルが終了したらタイマー表示を更新
        {
            _text.text = (_timer >= 10) ? _timer.ToString("F2") : "0" + _timer.ToString("F2");
        }
    }

    IEnumerator IntervalCoroutine()
    {
        float intervalTime = _invokeTime;
        while (intervalTime > 0)
        {
            _text.text = intervalTime.ToString("F0"); // インターバル時間の表示
            _text.DOColor(Color.red, 1).OnComplete(() => _text.DOColor(Color.white, 1));
            intervalTime -= Time.deltaTime;
            yield return null;
        }

        // インターバル終了時の表示
        _invokeTime = 0; // インターバル終了を示すために設定
        StartCoroutine(TimerCoroutine()); // タイマーのカウントダウンを開始
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
                    Debug.LogWarning("Audioがnullやで");
                }
            }
        }

        // タイマーが0になったら0に固定
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
