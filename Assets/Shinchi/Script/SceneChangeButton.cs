using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChangeButton : MonoBehaviour
{
    [SerializeField] string targetSceneName; // �ړ���̃V�[�������w�肷��
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
        yield return new WaitForSeconds(.5f); // 3�b�҂�
        SceneManager.LoadScene(targetSceneName); // �w�肵���V�[�����Ɉړ�����
        isCoroutineRunning = false;
    }
}
