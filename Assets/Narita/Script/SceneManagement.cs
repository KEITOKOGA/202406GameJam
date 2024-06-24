using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public static bool IsScene = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void SceneChange(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void GetNomal()
    {
        IsScene = true;
        SceneChange("Standby");
    }
    public void GetScoreAttack()
    {
        IsScene = false;
        SceneChange("Standby");
    }
    public void GetTitle()
    {
        SceneChange("Title");
    }
}
