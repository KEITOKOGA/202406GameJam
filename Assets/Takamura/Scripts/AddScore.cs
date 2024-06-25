using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{
    [SerializeField]GameObject ScrText;

    public static int score = 0;

    Text scoreText;

    public void Start()
    {
        scoreText = GetComponent<Text>();
    }

    // Start is called before the first frame update
    public void CountScore()
    {
        score++;

        scoreText.text = score.ToString();    
    }

    
}
