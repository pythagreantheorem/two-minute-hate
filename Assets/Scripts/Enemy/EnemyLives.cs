using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLives : MonoBehaviour {

    [SerializeField] public int maxLives;
    [SerializeField] public GameObject backgroundrunner;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name.Contains("Fireball"))
        {
            GameObject backgroundrunner = GameObject.Find("BackgroundRunning");
            SwitchingScenes switchscr = backgroundrunner.GetComponent<SwitchingScenes>();

            Destroy(other.gameObject);
            maxLives--;

            switchscr.AddKill();

            if (maxLives == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
