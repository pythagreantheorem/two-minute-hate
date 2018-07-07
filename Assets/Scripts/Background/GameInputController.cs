using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInputController : MonoBehaviour
{
    [SerializeField] private Pause _pause;
    [SerializeField] private Restart _restart;
    [SerializeField] private GameObject player;

    private void Start()
    {
       // _pause.ResetSpeed();
    }
    void Update ()
    {
        if (Input.GetButtonDown("Pause"))
        {
            Debug.Log("Totally pausing.");
            _pause.StopGame();
        }

        if (GameObject.Find("Player") == null && GameObject.Find("Player(Clone)") == null)
        {
            Vector3 pos = transform.position;
            pos.x = 5;
            Instantiate(player, pos, transform.rotation);
        }
    }
}
