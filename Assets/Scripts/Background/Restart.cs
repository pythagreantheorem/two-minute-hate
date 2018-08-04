using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    [SerializeField] private GameObject player;

    public void Respawn()
    {
        if (SceneManager.GetActiveScene().name != "Title Screen" && SceneManager.GetActiveScene().name != "HowTo1")
        {
            float camDistance = Vector3.Distance(transform.position, Camera.main.transform.position);
            Vector2 topCorner = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, camDistance));

            Vector3 pos = transform.position;
            pos.x = topCorner.x;
            pos.x = pos.x - 1;
            Instantiate(player, pos, transform.rotation);
        }
    }
}
