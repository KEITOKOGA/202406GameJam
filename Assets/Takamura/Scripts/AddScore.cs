using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{
    [SerializeField]GameObject ScrText;

    public static int score = 0;

    Text scoreText;

    bool origin = false;

    private void Awake()
    {
        if (origin == false)
        {
            DontDestroyOnLoad(this);

            origin = true;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void Start()
    {
        scoreText = GetComponent<Text>();

        try
        {
            scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        }
        catch { }
    }

    // Start is called before the first frame update
    //public void CountScore()
    //{
    //    score++;

    //    scoreText.text = score.ToString();    
    //}


    
}
