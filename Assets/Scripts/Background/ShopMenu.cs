using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMenu : MonoBehaviour
{
    [SerializeField] public bool _shopOpen;

    public void CreateDestroyShop()
    {
        Debug.Log("Creating/Destroying Shop");
    }
}
