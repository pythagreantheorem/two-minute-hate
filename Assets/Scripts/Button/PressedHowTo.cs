﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressedHowTo : MonoBehaviour
{
    public void ButtonClick()
    {
        GameObject.Find("LevelRunning").GetComponent<Pause>().StopGame();
        SceneManager.LoadScene("HowTo1");
    }
}
