using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumePressed : MonoBehaviour
{
    public void ButtonClick()
    {
        GameObject.Find("LevelRunning").GetComponent<Pause>().StopGame();
    }
}
