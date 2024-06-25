using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    [SerializeField] int[] _numbers;
    int[] nums = new int[9];
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


    AddScore _addscore;

    int scr = 1;
    [SerializeField] Text[] _order = new Text[8];
    [SerializeField] GameObject _explosionObject;
    [SerializeField] string _sceneName;
    TimerManager _timerManager;

    void Start()

    {
        //_timerManager = GameObject.Find("TimeMan").GetComponent<TimerManager>();
        //try
        //{
        //    _addscore = GameObject.Find("ScoreManager").GetComponent<AddScore>();
        //}
        //catch
        //{

        //}


        int[] numbers = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

        System.Random random = new System.Random();
        numbers = numbers.OrderBy(x => random.Next()).ToArray();
        _numbers = numbers;
        for (int i = 0; i < numbers.Length; i++)
        {
            //_order[i].text = _numbers[i].ToString();
        }

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
           

            //if (count == 9)
            //{
            //    _addscore.CountScore();
            //}
        }

        if (scr > 1 && (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S)
            || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.F)
            || Input.GetKeyDown(KeyCode.J) || Input.GetKeyDown(KeyCode.K)
            || Input.GetKeyDown(KeyCode.L) || Input.GetKeyDown(KeyCode.Semicolon)))
        {
            Debug.Log("Ç«Ç©Å[ÇÒ");
            Instantiate(_explosionObject, transform.position, Quaternion.identity);
            Invoke(nameof(GetScene), 3f);
            _timerManager._timer = 0;
        }
    }



    public void ParseNumber()
    {
        for (int i = 0; i < _numbers.Length; i++)
        {
            int x = _numbers[i];

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
                    Debug.Log("Ç«Ç©Å[ÇÒ");
                    Instantiate(_explosionObject, transform.position, Quaternion.identity);
                    Invoke(nameof(GetScene), 3f);
                    _timerManager._timer = 0;
                }
                else if (nums[count] == j)
                {
                    suc = true;
                }

            }
        }

        if (suc)
        {
            Debug.Log(count + "î‘ñ⁄" + "ê¨å˜");
            scr++;
            count++;
        }
    }
    void GetScene()
    {
        SceneManagement.SceneChange(_sceneName);
    }

}




