using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    [SerializeField] public int maxLives;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name.Contains("Waterball"))
        {
            Destroy(other.gameObject);
            maxLives--;

            if(maxLives == 0)
            {
                Destroy(gameObject);
            }
        }

        if(other.name.Contains("Enemy"))
        {
            Destroy(gameObject);
        }
    }

}

