using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public static bool IsScene = true;
    public static bool IsInGame = true;
    [Header("�^�C���A�^�b�N�C���Q�[���V�[��")]
    [SerializeField] string _sceneNormal;
    [Header("�G���h���X�C���Q�[���V�[��")]
    [SerializeField] string _sceneEnd;
    [Header("�^�C�g���V�[��")]
    [SerializeField] string _sceneTitle;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (IsInGame)
        {
            if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S) &&
                 Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.F))
            {
                GetNomal();
            }
            if (Input.GetKey(KeyCode.J) && !Input.GetKey(KeyCode.K) &&
               Input.GetKey(KeyCode.L) && !Input.GetKey(KeyCode.Semicolon))
            {
                GetScoreAttack();
            }
        }
    }
    public static void SceneChange(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void GetNomal()//�^�C���A�^�b�N���[�h
    {
        SceneChange(_sceneNormal);
        IsScene = true;
    }
    public void GetScoreAttack()//�G���h���X���[�h
    {
        SceneChange(_sceneEnd);
        IsScene = false;
    }
    public void GetTitle()//�^�C�g��
    {
        SceneChange(_sceneTitle);
        IsInGame = true;
    }
}
