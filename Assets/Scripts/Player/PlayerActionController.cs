using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActionController : MonoBehaviour
{
    [SerializeField] public GameObject spell;
    public bool canFire = true;

    public void UseEquippedSpell()
    {
        if (canFire == true)
        {
            Instantiate(spell, transform.position, transform.rotation);
            canFire = false;
            StartCoroutine("FireballWaitTime");
        }
    }

    IEnumerator FireballWaitTime()
    {
        yield return new WaitForSeconds(0.7f);
        canFire = true;
    }
}
