using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public static bool IsScene = true;
    public static bool IsInGame = true;
    [Header("タイムアタックインゲームシーン")]
    [SerializeField] string _sceneNormal;
    [Header("エンドレスインゲームシーン")]
    [SerializeField] string _sceneEnd;
    [Header("タイトルシーン")]
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
    public void GetNomal()//タイムアタックモード
    {
        SceneChange(_sceneNormal);
        IsScene = true;
    }
    public void GetScoreAttack()//エンドレスモード
    {
        SceneChange(_sceneEnd);
        IsScene = false;
    }
    public void GetTitle()//タイトル
    {
        SceneChange(_sceneTitle);
        IsInGame = true;
    }
}
