using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guster : PlayerSpell
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float maxSpeed;
    [SerializeField] private GameObject spell;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "EnemySpell")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if(other.tag == "Enemy")
        {
            float enemyspeed = other.GetComponent<EnemyLives>().maxSpeed;
            enemyspeed = maxSpeed;
            StartCoroutine("ChangeSpeed");
            Destroy(gameObject);
        }
    }

    private IEnumerator ChangeSpeed(System.Action callback)
    {
        yield return new WaitForSeconds(1.5f)
    }

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

        //Stop particle effect if paused
        if (_pause.paused != true)
        {
            //Instantiate(waterparticles, transform.position, transform.rotation);
        }
    }

    public override void UseSpell(Vector3 pos)
    {
        Instantiate(spell, pos, transform.rotation);
    }
}
