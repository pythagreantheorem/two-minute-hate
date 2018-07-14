using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] public float maxSpeed;
    [SerializeField] private GameObject waterparticles;
    [SerializeField] private GameObject fireparticles;


    private void Update()
    {
        //Setting up the variables
        float camDistance = Vector3.Distance(transform.position, Camera.main.transform.position);
        Vector2 bottomCorner = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, camDistance));
        Vector2 topCorner = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, camDistance));

        Vector2 velocity = new Vector2(maxSpeed, 0);
        _rigidbody.velocity = velocity;

        Pause _pause = GameObject.Find("LevelRunning").GetComponent<Pause>();

        //Destroying objects offscreen
        if (transform.position.x < bottomCorner.x)
        {
            Destroy(gameObject);
        }

        if (transform.position.x > topCorner.x)
        {
            Destroy(gameObject);
        }

        //Particle effects for projectiles
        if (_pause.paused != true)
        {
            if (this.name == "Fireball(Clone)")
            {
                Instantiate(waterparticles, transform.position, transform.rotation);
            }

            if (this.name == "Waterball(Clone)")
            {
                Instantiate(fireparticles, transform.position, transform.rotation);
            }
        }
    }
}
