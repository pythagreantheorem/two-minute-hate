using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLives : MonoBehaviour {

    [SerializeField] public int maxLives;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] public float maxSpeed;
    public bool resettrigger;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PlayerSpell")
        {
            Destroy(other.gameObject);
            maxLives--;

            GameObject.Find("LevelRunning").GetComponent<SwitchingScenes>().AddKill();

            if (maxLives == 0)
            {
                Destroy(gameObject);
            }
        }
    }

    private void Update()
    {
        //Setting up the variables
        float camDistance = Vector3.Distance(transform.position, Camera.main.transform.position);
        Vector2 bottomCorner = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, camDistance));
        Vector2 topCorner = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, camDistance));

        Vector2 velocity = new Vector2(maxSpeed, 0);
        _rigidbody.velocity = velocity;

        if (transform.position.x > topCorner.x)
        {
            Destroy(gameObject);
        }

        if(transform.position.x < bottomCorner.x - 0.25)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator ResetDirectionSpeed()
    {
        yield return new WaitForSeconds(1);
        resettrigger = true;
        ResetSpeed();
    }

    public void ResetSpeed()
    {
        if(resettrigger)
        {
            Debug.Log("reset");
        }
        else
        {
            Debug.Log("Start coroutine");
            StartCoroutine("ResetSpeed");
        }
    }
}
