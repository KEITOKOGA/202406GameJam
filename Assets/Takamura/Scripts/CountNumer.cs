using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountNumber : MonoBehaviour
{

    [SerializeField] TextMeshPro tex;
    public int num;

    void Start()
    {
        tex = GetComponent<TextMeshPro>();
        //AddNumber–¼‘O•Ï‚í‚é‚ç‚µ‚¢
        AddNumber();
        
    }

    private void Update()
    {
        
    }

    private void AddNumber()
    {
        num = (int)Random.Range(1, 9);

        Debug.Log(num);
    }
}
