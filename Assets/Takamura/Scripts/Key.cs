using System;
using UnityEngine;

public class Key : MonoBehaviour
{
    public bool a;
    public bool s;
    public bool d;
    public bool f;
    public bool h;
    public bool j;
    public bool k;
    public bool l;
    public bool p;

    CountNumber _countnum;

    [SerializeField] GameObject[] numbers;

    

    void Start()
    {
        Array.Sort(numbers);


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GetKey()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            a = true;

            numbers[0].SetActive(false);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            s = true;

            numbers[1].SetActive(false);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            d = true;

            numbers[2].SetActive(false);
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            f = true;

            numbers[3].SetActive(false);
        }

        if (Input.GetKeyUp(KeyCode.H))
        {
            h = true;

            numbers[4].SetActive(false);
        }

        if (Input.GetKeyUp(KeyCode.J))
        {
            j = true;

            numbers[5].SetActive(false);
        }

        if (Input.GetKeyUp(KeyCode.K))
        {
            numbers[6].SetActive(false);
        }

        if (Input.GetKeyUp(KeyCode.L))
        {
            numbers[7].SetActive(false);
        }

        if (Input.GetKeyUp(KeyCode.Semicolon))
        {
            p = true;

            numbers[8].SetActive(false);
        }

        if (a && s && d && f && h && j && k && l && p)
        {

            SceneManagement.SceneChange("Result");
        } 

    }
    
}
