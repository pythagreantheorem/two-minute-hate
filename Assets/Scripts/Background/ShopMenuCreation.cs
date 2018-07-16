using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMenuCreation : MonoBehaviour
{
    [SerializeField] public bool _shopOpen;
    [SerializeField] private PauseMenuCreation pausemenucreate;
    [SerializeField] private GameObject canvas;
    [SerializeField] private GameObject _shopHeader;
    [SerializeField] private GameObject _spellDropdown;
    [SerializeField] private GameObject exitbutton;

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
            Debug.Log("destroying shop");
        }
        else
        {
            Instantiate(_shopHeader, canvas.transform);
            Instantiate(_spellDropdown, canvas.transform);
            Instantiate(exitbutton, canvas.transform);
            Debug.Log("creating shop");
        }
    }
}
