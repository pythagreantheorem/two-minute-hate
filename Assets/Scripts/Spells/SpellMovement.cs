using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] public float maxSpeed;

    private void Update()
    {
        float camDistance = Vector3.Distance(transform.position, Camera.main.transform.position);
        Vector2 bottomCorner = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, camDistance));
        Vector2 topCorner = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, camDistance));

        Vector2 velocity = new Vector2(maxSpeed, 0);
        _rigidbody.velocity = velocity;

        if (transform.position.x < bottomCorner.x)
        {
            Destroy(gameObject);
        }

        if (transform.position.x > topCorner.x)
        {
            Destroy(gameObject);
        }
    }

    public void ResetMaxSpeed()
    {
        if (this.name.Contains("Enemy"))
        {
            maxSpeed = 2;
        }

        if (this.name.Contains("Fireball"))
        {
            maxSpeed = -4;
        }

        if (this.name.Contains("Waterball"))
        {
            maxSpeed = 4;
        }
    }
}
