using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInputController : MonoBehaviour
{
    [SerializeField] private Pause _pause;
    [SerializeField] private Restart _restart;
    [SerializeField] private GameObject player;

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
            Vector3 pos = transform.position;
            pos.x = topCorner.x;
            pos.x = pos.x - 1;
            Instantiate(player, pos, transform.rotation);
        }
    }
}
