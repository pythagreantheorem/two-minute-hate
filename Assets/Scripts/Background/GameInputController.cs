using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInputController : MonoBehaviour
{
    [SerializeField] private Pause _pause;
    [SerializeField] private Restart _restart;

    void Update()
    {
        float camDistance = Vector3.Distance(transform.position, Camera.main.transform.position);
        Vector2 topCorner = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, camDistance));

        if (Input.GetButtonDown("Pause"))
        {
            _pause.StopGame();
        }

        if (GameObject.Find("Player") == null && GameObject.Find("Player(Clone)") == null)
        {
            _restart.Respawn();
        }
    }
}
