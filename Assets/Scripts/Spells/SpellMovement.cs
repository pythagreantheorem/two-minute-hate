using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _maxSpeed;

    private void Update()
    {
        float camDistance = Vector3.Distance(transform.position, Camera.main.transform.position);
        Vector2 bottomCorner = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, camDistance));
        Vector2 topCorner = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, camDistance));

        Vector2 velocity = new Vector2(_maxSpeed, 0);
        _rigidbody.velocity = velocity;

        if(transform.position.x < bottomCorner.x)
        {
            Destroy(gameObject);
        }

        if(transform.position.x > topCorner.x)
        {
            Destroy(gameObject);
        }
    }
}
