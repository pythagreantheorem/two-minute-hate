using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActionController : MonoBehaviour
{
    [SerializeField] public GameObject spell;
    [SerializeField] private SpellToolbox _toolbox;
    public bool canFire = true;

    public void UseEquippedSpell()
    {
        if (canFire == true)
        {
            Vector3 pos = transform.position;
            _toolbox.UseEquippedSpell(pos);
            canFire = false;
            StartCoroutine("FireballWaitTime");
        }
    }

    IEnumerator FireballWaitTime()
    {
        yield return new WaitForSeconds(0.7f);
        canFire = true;
    }

    public void EquipNextSpell()
    {
        _toolbox.EquipNextSpell();
    }
}
