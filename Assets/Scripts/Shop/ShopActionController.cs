using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopActionController : MonoBehaviour
{
    private int pricetotal;
    public Text totaldisplayer;
    public Text buytext;

    public void FindTotal(int index)
    {
        switch(index)
        {
            case 0:
                pricetotal = 0;
                break;
            case 1:
                pricetotal = 15;
                break;
            case 2:
                pricetotal = 25;
                break;
        }
        DisplayBuyButton();
    }

    private void DisplayBuyButton()
    {
        string totaltemplate = "Total: " + pricetotal;
        totaldisplayer.text = pricetotal.ToString();
        Debug.Log(totaldisplayer.text);
    }

    private void Start()
    {
        pricetotal = 0;
    }
}
