using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountNumber : MonoBehaviour
{

    int num;

    void Start()
    {
        
    }

    private void Update()
    {
        AddNumber();
    }

    private void AddNumber()
    {
        num = (int)Random.Range(1, 9);

        Debug.Log(num);
    }
}
