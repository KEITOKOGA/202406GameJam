using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimerMan : MonoBehaviour
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

    void Start()
    {
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
        }

        // タイマーが0になったら0に固定
        _timer = 0;
        _text.enabled = false;

        if (SceneManagement.IsScene == true)
        {
            _fadePanel.gameObject.SetActive(true);
            _fadePanel.material.DOFade(_EndFadeMode, _interval).OnComplete(() => SceneManagement.SceneChange("Result"));
        }
    }
}
