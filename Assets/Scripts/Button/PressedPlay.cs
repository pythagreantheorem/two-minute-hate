﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressedPlay : MonoBehaviour
{
    public void ButtonClick()
    {
        SceneManager.LoadScene("1");
    }
}
