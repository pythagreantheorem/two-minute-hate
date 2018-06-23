using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLives : MonoBehaviour {

    [SerializeField] public int maxLives;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name.Contains("Fireball"))
        {
            Destroy(other.gameObject);
            maxLives--;

            if (maxLives == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
