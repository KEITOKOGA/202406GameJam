using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class CountNumber : MonoBehaviour
{
    [SerializeField] Text _numberText; // テキストを表示するもの
    [SerializeField] Text _numberText1;
    [SerializeField] Text _numberText2;
    [SerializeField] Text _numberText3;
    [SerializeField] Text _numberText4;
    [SerializeField] Text _numberText5;
    [SerializeField] Text _numberText6;
    [SerializeField] Text _numberText7;

    public int num; // 現在の数字
    public int[] _numbers; // 数字の配列

    void Start()
    {
        _numberText = GetComponent<Text>();
        //AddNumber名前変わるらしい
        AddNumber();
    }

    public void AddNumber() // 数字を出力する
    {
        int[] numbers = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

        System.Random random = new System.Random();
        numbers = numbers.OrderBy(x => random.Next()).ToArray();
        _numbers = numbers;
        //intでほしい場合は変数から直接どうぞ
        _numberText.text = _numbers[0].ToString();
        _numberText1.text = _numbers[1].ToString();
        _numberText2.text = _numbers[2].ToString();
        _numberText3.text = _numbers[3].ToString();
        _numberText4.text = _numbers[4].ToString();
        _numberText5.text = _numbers[5].ToString();
        _numberText6.text = _numbers[6].ToString();
        _numberText7.text = _numbers[7].ToString();
    }
}