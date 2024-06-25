using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneStandby : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetScene();
        }
    }
    void GetScene()
    {
        if (SceneManagement.IsScene == true)
        {
            SceneManagement.SceneChange("Nomal");
            SceneManagement.IsInGame = false;
        }
        else if (SceneManagement.IsScene == false)
        {
            SceneManagement.SceneChange("ScoreAttack");
            SceneManagement.IsInGame = false;
        }
    }
}
