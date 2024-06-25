using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    [SerializeField] Text[] _key = new Text[8];
    int[] _keys = new int[] {(int)KeyCode.A, (int)KeyCode.S, (int)KeyCode.D, (int)KeyCode.F,
        (int)KeyCode.J, (int)KeyCode.K, (int)KeyCode.L, (int)KeyCode.Semicolon};
    int _cmdCount = 0;
    [SerializeField] float _interval = 0;

    private void Start()
    {
        System.Random rng = new System.Random();
        int length = _keys.Length;
        while (length > 1)
        {
            length--;
            int k = rng.Next(length + 1);
            int tmp = _keys[k];
            _keys[k] = _keys[length];
            _keys[length] = tmp;
        }
    }
    private void Update()
    {
        _interval += Time.deltaTime;
        if( _interval > 3 )
        {
            for(int i = 0; i < _keys.Length; i++)
            {
                _key[i].text = ((char)_keys[i]).ToString().ToUpper();
            }
            for(int i = 0; i < _keys.Length; i++)
            {
                if (Input.GetKeyUp((KeyCode)_keys[i]))
                {
                    _cmdCount += 1;
                    if(_cmdCount == 8)
                    {
                        Debug.Log("Clear");
                    }
                }

            }
        }
    }
}
