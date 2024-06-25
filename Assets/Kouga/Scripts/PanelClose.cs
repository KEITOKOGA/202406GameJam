using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelClose : MonoBehaviour
{
    [SerializeField] GameObject _panel;
    [SerializeField] GameObject _closeButton;
    public void PanelActive()
    {
        _panel.SetActive(false);
        _closeButton.SetActive(false);
    }
}
