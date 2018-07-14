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
            paused = false;
            GameObject shadowedbg = GameObject.Find("DarkneningPause(Clone)");
            Destroy(shadowedbg);
        }
        else
        {
            Time.timeScale = 0;
            paused = true;
            Instantiate(darkbackground, transform.position, transform.rotation);
        }

        _pausemenucreate.Menu(paused);
    }
}
