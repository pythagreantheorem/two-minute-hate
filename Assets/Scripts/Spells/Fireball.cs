using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _maxSpeed;

    private void Update()
    {
        Vector2 velocity = new Vector2(_maxSpeed, 0);
        _rigidbody.velocity = velocity;
    }
}
