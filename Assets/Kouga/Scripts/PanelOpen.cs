using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelOpen : MonoBehaviour
{
    [SerializeField] GameObject _panel;
    [SerializeField] GameObject _closeButton;
    public void PanelActive()
    {
        _panel.SetActive(true);
        _closeButton.SetActive(true);
    }
}
