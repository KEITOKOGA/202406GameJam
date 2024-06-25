using System.Linq;
using UnityEngine;
<<<<<<< HEAD
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
=======
using UnityEngine.SceneManagement;
using UnityEngine.UI;
>>>>>>> 4e5d623da091d44c6bef0cc57d279efdf778e64c

public class Key : MonoBehaviour
{
    [SerializeField] string _gameoverResult; // 移動先のシーン名を指定する
    [SerializeField] string _successResult; // 移動先のシーン名を指定する
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


<<<<<<< HEAD
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
            Debug.Log("どかーん");
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
                    Debug.Log("どかーん");
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
            Debug.Log(count + "番目" + "成功");
            scr++;
            count++;
        }
    }
    void GetScene()
    {
        SceneManagement.SceneChange(_sceneName);
    }

}




=======
    AddScore _addscore;

    int scr = 1;
    [SerializeField] Text[] _order = new Text[8];
    [SerializeField] GameObject _audioPurefab;

    void Start()

    {
        try
        {
            _addscore = GameObject.Find("ScoreManager").GetComponent<AddScore>();
        }
        catch
        {

        }


        int[] numbers = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

        System.Random random = new System.Random();
        numbers = numbers.OrderBy(x => random.Next()).ToArray();
        _numbers = numbers;
        for (int i = 0; i < numbers.Length; i++)
        {
            _order[i].text = _numbers[i].ToString();
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

            if (count == 9)
            {
                SceneManager.LoadScene(_successResult);
            }
        }

        if (scr > 1 && (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S)
            || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.F)
            || Input.GetKeyDown(KeyCode.J) || Input.GetKeyDown(KeyCode.K)
            || Input.GetKeyDown(KeyCode.L) || Input.GetKeyDown(KeyCode.Semicolon)))
        {
            SceneManager.LoadScene(_gameoverResult);
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
                    Instantiate(_audioPurefab, transform.position, Quaternion.identity);
                    Invoke(nameof(GetSceneFailed), 1);
                    
                }
                else if (nums[count] == j)
                {
                    suc = true;
                }

            }
        }

        if (suc)
        {
            Debug.Log(count + "番目" + "成功");
            count++;
            scr++;
        }
    }
    void GetSceneFailed()
    {
        SceneManagement.SceneChange(_gameoverResult);
    }
}
>>>>>>> 4e5d623da091d44c6bef0cc57d279efdf778e64c
