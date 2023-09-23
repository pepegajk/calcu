﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    public Button exitButton;
    // Start is called before the first frame update
    void Start()
    {
        exitButton.onClick.AddListener(ExitGame);
    }

    // Update is called once per frame
    void ExitGame()
    {
        Application.Quit();
    }
}
