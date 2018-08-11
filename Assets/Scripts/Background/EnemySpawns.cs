using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawns : MonoBehaviour {

    [SerializeField] public float _secsmin;
    [SerializeField] public float _secsmax;
    [SerializeField] GameObject enemy;

    private void Start()
    {
        if (SceneManager.GetActiveScene().name != "Title Screen" && SceneManager.GetActiveScene().name != "HowTo1")
        {
            StartCoroutine("Spawning");
        }
    }

    private IEnumerator Spawning()
    {
        for (int i = 0; i < 100; i++)
        {
            float camDistance = Vector3.Distance(transform.position, Camera.main.transform.position);
            Vector2 bottomCorner = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, camDistance));
            Vector2 topCorner = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, camDistance));

            Vector3 pos = new Vector3(bottomCorner.x, UnityEngine.Random.Range(bottomCorner.y, topCorner.y), 0);
            Instantiate(enemy, pos, transform.rotation);
            yield return new WaitForSeconds(UnityEngine.Random.Range(_secsmin, _secsmax));
        }
    }
}
