using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [Header("制限時間")]
    public float _timer = 10;
    [Header("表示するテキスト")]
    [SerializeField] Text _text;
    [Header("開始までの時間")]
    [SerializeField] float _invokeTime = 1;
    float _changeTimer;
    [Header("リザルト画面に移行するまでの時間")]
    [SerializeField] float _changeTime = 1;
    [Header("タイムオーバー時に流したい音声")]
    [SerializeField] AudioSource _audio;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //テキスト表示
        //_text.text = _timer.ToString("F2");
        if (_timer >= 10)
        {
            _text.text = _timer.ToString("F2");
        }
        else
        {
            _text.text = "0" + _timer.ToString("F2");
        }
        //_invokeTimeの分遅らせて制限時間のメソッドを呼び出す
        Invoke(nameof(TimerStart), _invokeTime);
    }
    void TimerStart() //制限時間のメソッド
    {
        _timer -= Time.deltaTime;
        //タイマーが0になったら0に固定
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
                Debug.LogWarning("AudioSourceにアタッチされていません");
            }
            if (SceneManagement.IsScene == true && _changeTimer >= _changeTime)
            {
                SceneManagement.SceneChange("Result");
            }
        }
    }
}
