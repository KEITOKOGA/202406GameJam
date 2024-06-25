using System;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    bool a;
    bool s;
    bool d;
    bool f;
    bool h;
    bool j;
    bool k;
    bool l;
    bool p;

    CountNumber _countnum;

    //[SerializeField] GameObject[] numbers;

    [SerializeField] int[] numbers2;

    int[] nums = new int[9];

    Dictionary<int, int> _dictionary;

    string[] array = { "a", "s", "d", "f", "j", "k", "l", "+" };
        
    int[] keytype = new[] {
           
            (int)KeyCode.A, 
            (int)KeyCode.S,
            (int)KeyCode.D,
            (int)KeyCode.F,
            (int)KeyCode.J,
            (int)KeyCode.K,
            (int)KeyCode.L,
            (int)KeyCode.Semicolon,
       
        };

    

    bool suc;


    void Update()
    {


        ParseNumber();

       GetKey();
    }
    public void ParseNumber()
    {


        for (int i = 0; i < numbers2.Length; i++)
        {
            int x = numbers2[i];

            nums[x] = i;
        }

    }

    public void GetKey()
    {
        if (Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.S) &&
            Input.GetKeyDown(KeyCode.D) && Input.GetKeyDown(KeyCode.F) &&
            Input.GetKeyDown(KeyCode.J) && Input.GetKeyDown(KeyCode.K) &&
            Input.GetKeyDown(KeyCode.L) && Input.GetKeyDown(KeyCode.Semicolon) )
        { Debug.Log("error");

            return;
        }

      

        for (int i = 1;i < 9;i++)
        {
            suc= false; 
            for(; ; ){
                for (int j = 0; j < 8; j++)
                {


                    if (Input.GetKeyUp((KeyCode)keytype[j]))
                    {
                        if (nums[i] != j)
                        {
                            Debug.Log("Ž¸”s");
                        }
                        else if (nums[i] == j)
                        {
                            suc = true;
                        }

                    }
                }

                    if (suc)
                    {
                    Debug.Log(i + "”Ô–Ú" + "¬Œ÷");
                        break;
                    }
                

            }

            
        
            //if (Input.GetKeyUp(KeyCode.A) && a == false)
            //{
            //    a = true;

            //    numbers[0].SetActive(false);
            //}

            //else if (Input.GetKeyUp(KeyCode.S) && s == false)
            //{
            //    s = true;

            //    numbers[1].SetActive(false);
            //}

            //else if (Input.GetKeyUp(KeyCode.D) && d == false)
            //{
            //    d = true;

            //    numbers[2].SetActive(false);
            //}

            //else if (Input.GetKeyUp(KeyCode.F) && f == false)
            //{
            //    f = true;

            //    numbers[3].SetActive(false);
            //}

            //else if (Input.GetKeyUp(KeyCode.J) && j == false)
            //{
            //    j = true;

            //    numbers[4].SetActive(false);
            //}

            //else if (Input.GetKeyUp(KeyCode.K) && k == false)
            //{
            //    k = true;

            //    numbers[5].SetActive(false);
            //}

            //else if (Input.GetKeyUp(KeyCode.L) && l == false)
            //{
            //    numbers[6].SetActive(false);

            //    l = true;
            //}

            //else if (Input.GetKeyUp(KeyCode.Semicolon) && p == false)
            //{
            //    numbers[7].SetActive(false);

            //    p = true;
            //}

          
        }

        

    }

}
