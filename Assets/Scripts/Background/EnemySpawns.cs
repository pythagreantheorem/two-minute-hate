using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawns : MonoBehaviour {

    [SerializeField] float _secsmin;
    [SerializeField] float _secsmax;
    [SerializeField] GameObject enemy;

    private void Start()
    {
        StartCoroutine("Spawning");
    }

    private IEnumerator Spawning()
    {
        for (int i = 0; i < 100; i++)
        {
            Vector3 pos = new Vector3(-6, UnityEngine.Random.Range(-3.44f, 3.62f), 0);
            Instantiate(enemy, pos, transform.rotation);
            yield return new WaitForSeconds(UnityEngine.Random.Range(_secsmin, _secsmax));
        }
    }
}
