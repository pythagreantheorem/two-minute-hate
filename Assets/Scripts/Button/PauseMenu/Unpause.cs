using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unpause : MonoBehaviour
{

    public void StopPausing()
    {
        GameObject.Find("LevelRunning").GetComponent<Pause>().StopGame();
    }
}
