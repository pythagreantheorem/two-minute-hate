using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCollisions : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name.Contains("Waterball"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
