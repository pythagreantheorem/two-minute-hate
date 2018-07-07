using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] public bool paused;

    public void StopGame()
    {
        SpellMovement instEsp = GameObject.FindGameObjectWithTag("Enemy").GetComponent<SpellMovement>();
        PlayerMovement instPm = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        SpellMovement instWsp = GameObject.FindGameObjectWithTag("Waterball").GetComponent<SpellMovement>();
        SpellMovement instFsp = GameObject.FindGameObjectWithTag("Fireball").GetComponent<SpellMovement>();

        if (paused)
        {
            instEsp.maxSpeed = 2;
            instFsp.maxSpeed = -4;
            instPm._maxSpeed = 4;
            instWsp.maxSpeed = 4;
        }
        else
        {
            instEsp.maxSpeed = 0;
            instFsp.maxSpeed = 0;
            instPm._maxSpeed = 0;
            instWsp.maxSpeed = 0;

            paused = true;
        }
    }
}
