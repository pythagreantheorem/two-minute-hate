using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerSpell : MonoBehaviour
{
    public abstract void UseSpell(Vector3 pos);
}
