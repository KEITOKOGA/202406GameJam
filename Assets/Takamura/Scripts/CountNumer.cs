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
        //AddNumber���O�ς��炵��
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
