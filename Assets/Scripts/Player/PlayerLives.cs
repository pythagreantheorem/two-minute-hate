using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLives : MonoBehaviour
{
    [SerializeField] public int maxLives;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name.Contains("Waterball"))
        {
            Destroy(other.gameObject);
            maxLives--;
            CheckIfDead();
        }

        if(other.name.Contains("Enemy"))
        {
            Destroy(other.gameObject);
            maxLives--;
            maxLives--;
            CheckIfDead();
        }
    }

    private void CheckIfDead()
    {
        if(maxLives <= 0)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }

}

