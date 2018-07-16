using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressedExitShop : MonoBehaviour
{
    public void ButtonClick()
    {
        Debug.Log("Exiting Shop");
        GameObject.Find("LevelRunning").GetComponent<ShopMenuCreation>().CreateDestroyPauseMenu();
    }
}
