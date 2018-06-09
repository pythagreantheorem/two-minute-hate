using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _maxSpeed;

    private void FixedUpdate()
    {
        float axis = Input.GetAxis("Vertical");
        Vector2 velocity = new Vector2(0, (_maxSpeed * axis));
        _rigidbody.velocity = velocity;

    }

    private void Update()
    {
        float camDistance = Vector3.Distance(transform.position, Camera.main.transform.position);
        Vector2 bottomCorner = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, camDistance));
        Vector2 topCorner = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, camDistance));
        Vector2 pos = transform.position;

        if(transform.position.y <bottomCorner.y)
        {
            pos.y = bottomCorner.y;
        }

        if(transform.position.y > topCorner.y)
        {
            pos.y = topCorner.y;
        }

        transform.position = pos;
    }
}