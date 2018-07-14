using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] public bool paused;
    [SerializeField] GameObject darkbackground;
    [SerializeField] PauseMenuCreation _pausemenucreate;

    public void StopGame()
    {
        if (paused)
        {
            Time.timeScale = 1;
            GameObject shadowedbg = GameObject.Find("DarkneningPause(Clone)");
            Destroy(shadowedbg);
            paused = false;
        }
        else
        {
            Time.timeScale = 0;
            Instantiate(darkbackground, transform.position, transform.rotation);
            paused = true;
        }

        _pausemenucreate.Menu(paused);
    }
}
