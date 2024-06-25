using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [Header("制限時間")]
    public float _timer = 10;
    [Header("表示するテキスト")]
    [SerializeField] Text _text;
    [Header("開始までの時間")]
    [SerializeField] float _invokeTime = 1;
    [SerializeField] float _interval;
    [SerializeField] Image _fadePanel = default;
    [SerializeField] int _fadeMode;
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
            if (SceneManagement.IsScene == true)
            {
                _fadePanel.gameObject.SetActive(true);
                this._fadePanel.material.DOFade(_fadeMode,_interval).OnComplete(()=> SceneManagement.SceneChange("Result"));
            }
        }
    }
}
