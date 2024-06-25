using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneBack : MonoBehaviour
{
    [SerializeField] string targetSceneName2; // 移動先のシーン名を指定する
    private bool isCoroutineRunninG = false;

    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(ChangeScene2);
    }

    void ChangeScene2()
    {
        if (!isCoroutineRunninG)
        {
            StartCoroutine(DelayedSceneChange2());
        }
    }

    IEnumerator DelayedSceneChange2()
    {
        isCoroutineRunninG = true;
        yield return new WaitForSeconds(.5f); // .5秒待つ
        SceneManager.LoadScene(targetSceneName2); // 指定したシーン名に移動する
        isCoroutineRunninG = false;
    }
}