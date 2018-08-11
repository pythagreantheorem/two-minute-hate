using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellToolbox : MonoBehaviour
{
    [SerializeField] private PlayerSpell[] _spells;
    private int _spellIndex;

    public void UseEquippedSpell(Vector3 pos)
    {
        _spells[_spellIndex].UseSpell(pos);
    }

    public void EquipNextSpell()
    {
        _spellIndex = (_spellIndex + 1) % _spells.Length;
    }
}
