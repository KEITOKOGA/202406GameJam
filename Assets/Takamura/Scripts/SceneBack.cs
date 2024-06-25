using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneBack : MonoBehaviour
{
    [SerializeField] string targetSceneName2; // �ړ���̃V�[�������w�肷��
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
        yield return new WaitForSeconds(.5f); // .5�b�҂�
        SceneManager.LoadScene(targetSceneName2); // �w�肵���V�[�����Ɉړ�����
        isCoroutineRunninG = false;
    }
}