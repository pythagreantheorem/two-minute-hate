﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressedShop : MonoBehaviour
{
    public void ButtonClick()
    {
        GameObject.Find("LevelRunning").GetComponent<ShopMenuCreation>().CreateDestroyPauseMenu();
    }
}
