using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonExit : MonoBehaviour
{
    Button myButton;

    private void Awake()
    {
        myButton = GetComponent<Button>();
    }
    void Start()
    {
        myButton.onClick.AddListener(Exit);
    }

    void Exit()
    {
        Application.Quit();
    }
}
