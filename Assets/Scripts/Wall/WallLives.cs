using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallLives : MonoBehaviour
{
    [SerializeField] public int maxLives;
    [SerializeField] SpriteRenderer _spriteRenderer;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name.Contains("Waterball"))
        {
            Destroy(other.gameObject);
            maxLives--;
            Debug.Log(maxLives);

            switch (maxLives)
            {
                case 4:

                    break;
                case 3:

                    break;
                case 2:

                    break;
                case 1:

                    break;
                case 0:
                    Destroy(gameObject);
                    break;
                default:
                    Debug.Log("maxLives outside 0 - 5");
                   break;
            }
        }
    }
}
