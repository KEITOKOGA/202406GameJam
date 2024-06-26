using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneBackButtun : MonoBehaviour
{
    [SerializeField] string targetSceneName; // 移動先のシーン名を指定する
    private bool isCoroutineRunning = false;

    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(ChangeScene);
    }

    void ChangeScene()
    {
        if (!isCoroutineRunning)
        {
            StartCoroutine(DelayedSceneChange());
        }
    }

    IEnumerator DelayedSceneChange()
    {
        isCoroutineRunning = true;
        yield return new WaitForSeconds(0.5f); // .5秒待つ
        SceneManager.LoadScene(targetSceneName); // 指定したシーン名に移動する
        isCoroutineRunning = false;
    }
}
