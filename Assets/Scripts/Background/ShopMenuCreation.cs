using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMenuCreation : MonoBehaviour
{
    [SerializeField] public bool _shopOpen;
    [SerializeField] private PauseMenuCreation pausemenucreate;
    [SerializeField] private GoldDisplay _golddisplaycs;
    [SerializeField] private GameObject canvas;
    [SerializeField] private GameObject _shopHeader;
    [SerializeField] private GameObject _spellDropdown;
    [SerializeField] private GameObject exitbutton;
    [SerializeField] private GameObject golddisplay;
    [SerializeField] private GameObject buybutton;

    public void CreateDestroyPauseMenu()
    {
        if(_shopOpen)
        {
            pausemenucreate.Menu(_shopOpen);
            CreateDestroyShop();
            _shopOpen = false;
        }
        else
        {
            pausemenucreate.Menu(_shopOpen);
            CreateDestroyShop();
            _shopOpen = true;
        }
    }

    public void CreateDestroyShop()
    {
        if(_shopOpen)
        {
            Destroy(GameObject.Find("ShopHeader(Clone)"));
            Destroy(GameObject.Find("SpellsDropdown(Clone)"));
            Destroy(GameObject.Find("ExitShop(Clone)"));
            Destroy(GameObject.Find("Gold Display(Clone)"));
            Destroy(GameObject.Find("BuyButton(Clone)"));
        }
        else
        {
            _golddisplaycs.DisplayGold();
            Instantiate(_shopHeader, canvas.transform);
            Instantiate(_spellDropdown, canvas.transform);
            Instantiate(exitbutton, canvas.transform);
            Instantiate(golddisplay, canvas.transform);
            Instantiate(buybutton, canvas.transform);
        }
    }
}
