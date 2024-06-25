using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    public static int score = 0;

    // Start is called before the first frame update
   public void CountScore()
    {
        score++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
