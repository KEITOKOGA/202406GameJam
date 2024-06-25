using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    [SerializeField] GameObject _panel;
    void PanelActive()
    {
        _panel.SetActive(true);
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _panel.SetActive(false);
        }
    }
}
