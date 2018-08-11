using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopInputController : MonoBehaviour
{
    [SerializeField] private ShopActionController shopaction;

    public void SpellSelected(Dropdown spelldrop)
    {
        shopaction.FindTotal(spelldrop.value);
    }
}
