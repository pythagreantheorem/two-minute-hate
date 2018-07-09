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
            SwitchingScenes switchscript = backgroundrunner.GetComponent<SwitchingScenes>();

            Destroy(other.gameObject);
            maxLives--;

           switchscript.AddKill();

            if (maxLives == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
