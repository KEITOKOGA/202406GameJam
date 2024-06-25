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
<<<<<<< HEAD

    //[SerializeField] GameObject[] numbers;

    [SerializeField] int[] numbers2;

    int[] nums = new int[9];

=======
    [SerializeField] GameObject[] numbers;
    [SerializeField] int[] numbers2;
    int[] nums = new int[8];
>>>>>>> d963708f9884312f59c9d675c5961d1490451436
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

    int aaaa = 0;
    bool suc;


    void Start()
    {
        ParseNumber();

       GetKey();
    }
    private void Update()
    {

    }

    public void ParseNumber()
    {
        //var queue = new Queue<int>();

        //queue.Enqueue(numbers2[0]);
        //queue.Enqueue(numbers2[1]);
        //queue.Enqueue(numbers2[2]);
        //queue.Enqueue(numbers2[3]);
        //queue.Enqueue(numbers2[4]);
        //queue.Enqueue(numbers2[5]);
        //queue.Enqueue(numbers2[6]);
        //queue.Enqueue(numbers2[7]);

        //nums = numbers2;   numbers    4 3 6 1 2 7 8 5
        //                   nums       3 4 1 0 7 2 5 6
        //                             F J S A + D K L]nums[1] = 3

        for (int i = 0; i < numbers2.Length; i++)
        {
            int x = numbers2[i];
            nums[x] = i;
        }

        //_dictionary = new Dictionary<int, int>();

        //_dictionary.Add(numbers2[0],nums);
        //_dictionary.Add(numbers2[1], "S");
        //_dictionary.Add(numbers2[2], "D");
        //_dictionary.Add(numbers2[3], "F");
        //_dictionary.Add(numbers2[4], "J");
        //_dictionary.Add(numbers2[5], "K");
        //_dictionary.Add(numbers2[6], "L");
        //_dictionary.Add(numbers2[7], "+");
    }

    public void GetKey()
    {
        for (int i = 1; i < 9; i++)
        {
<<<<<<< HEAD
            suc= false; 
            for(; ; ){
                for (int j = 0; j < 8; j++)
                {


                    if (Input.GetKeyUp((KeyCode)j))
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

        

=======
            for (int j = 0; j < 8; j++)
            {
                if (Input.GetKeyUp((KeyCode)j))
                {
                    if (nums[i] != j)
                    {
                        //false
                    }
                    else if (nums[i] == j)
                    {
                        suc = true;
                    }
                    else
                    {
                    }
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
>>>>>>> d963708f9884312f59c9d675c5961d1490451436
    }
}
