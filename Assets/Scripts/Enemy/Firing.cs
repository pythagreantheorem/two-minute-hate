using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour {

    [SerializeField] GameObject spell;
	void Start ()
    {
        StartCoroutine("StartAttack");
	}

    IEnumerator StartAttack()
    {
        for (int i = 0; i < 6; i++)
        {
            yield return new WaitForSeconds(2);
            Instantiate(spell, transform.position, transform.rotation);

        }
    }
}
