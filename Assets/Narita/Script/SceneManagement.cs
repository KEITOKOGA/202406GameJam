using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public static bool IsScene = true;
    public static bool IsInGame = true;
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
        IsScene = true;
        SceneChange("Standby");
    }
    public void GetScoreAttack()//エンドレスモード
    {
        IsScene = false;
        SceneChange("Standby");
    }
    public void GetTitle()//タイトル
    {
        SceneChange("Title");
        IsInGame = true;
    }
}
