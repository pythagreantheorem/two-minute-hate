using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressedShop : MonoBehaviour
{
    public void ButtonClick()
    {
        Debug.Log("Shop Create");
        GameObject.Find("LevelRunning").GetComponent<ShopMenu>().CreateDestroyShop();
    }
}
