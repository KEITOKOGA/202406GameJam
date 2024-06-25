using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Ranking : MonoBehaviour
{
    [SerializeField] Text[] texts;

    private static int[] scores = new int[6];

    void Start()
    {

        if (AddScore.score == 0)
        {

            scores[5] = AddScore.score;

            Array.Sort(scores);

            Array.Reverse(scores);

            GetRanking();



            Debug.Log("スコアなし" );
        }
        else
        {

            scores[5] = AddScore.score;

            Array.Sort(scores);

            Array.Reverse(scores);

            GetRanking();



            Debug.Log("スコアを計算" );
        }
    }
    void GetRanking()
    {
        for (int i = 0; i < scores.Length - 1; i++)
        {
            texts[i].text = " " + scores[i];

        }

    }// Update is called once per frame
    void Update()
    {
        
    }
}
