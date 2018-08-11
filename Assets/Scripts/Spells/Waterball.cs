using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Specific things that this spell does
public class Waterball : PlayerSpell
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float maxSpeed;
    [SerializeField] private GameObject waterparticles;
    [SerializeField] private GameObject waterballsp;

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

        //Stop particle effect if paused
        if (_pause.paused != true)
        {
            Instantiate(waterparticles, transform.position, transform.rotation);
        }
    }

    public override void UseSpell(Vector3 pos)
    {
        Instantiate(waterballsp, pos, transform.rotation);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "EnemySpell")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
