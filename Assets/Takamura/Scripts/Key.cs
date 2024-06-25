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
    //string[] array = { "a", "s", "d", "f", "j", "k", "l", "+" };   
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

    int count = 1;

    void Start()
    {
        ParseNumber();

        Debug.Log("stop");
       
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S)
            || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.F)
            || Input.GetKeyUp(KeyCode.J) || Input.GetKeyUp(KeyCode.K)
            || Input.GetKeyUp(KeyCode.L) || Input.GetKeyUp(KeyCode.Semicolon))
        {
            GetKey();
            count++;
        }
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
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S) &&
            Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.F) &&
            Input.GetKey(KeyCode.J) && Input.GetKey(KeyCode.K) &&
            Input.GetKey(KeyCode.L) && Input.GetKey(KeyCode.Semicolon))
        {
            Debug.Log("ok");

        }
        else
        {
            Debug.Log("error");
        }



        suc = false;

        for (int j = 0; j < 8; j++)
        {


            if (Input.GetKeyUp((KeyCode)keytype[j]))
            {
                Debug.Log("st");
                if (nums[count] != j)
                {
                    Debug.Log("Ž¸”s");
                }
                else if (nums[count] == j)
                {
                    suc = true;
                }

            }
        }

        if (suc)
        {
            Debug.Log(count + "”Ô–Ú" + "¬Œ÷");

        }
    }

}




