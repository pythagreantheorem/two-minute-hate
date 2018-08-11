using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopActionController : MonoBehaviour
{
    private int pricetotal;
    public Text totaldisplayer;
    public Text buytext;
    public bool gusterbought;
    [SerializeField] private Dropdown spelldrop;

    public void BuyItems()
    {
        if (GameObject.Find("LevelRunning").GetComponent<GoldDisplay>().goldamount > 9 && gusterbought == false)
        {
            int currentgold = GameObject.Find("LevelRunning").GetComponent<GoldDisplay>().goldamount;
            GameObject.Find("LevelRunning").GetComponent<GoldDisplay>().goldamount = currentgold - 10;
            gusterbought = true;
        }
    }

    public int FindTotal(int index)
    {
        switch(index)
        {
            case 0:
                pricetotal = 0;
                break;
            case 1:
                pricetotal = 9;
                break;
        }
        return pricetotal;
    }

   // private void DisplayBuyButton()
   // {
   //     string totaltemplate = "Total: " + pricetotal;
   //     totaldisplayer.text = pricetotal.ToString();
   //     Debug.Log(totaldisplayer.text);
   // }

    private void Start()
    {
        pricetotal = 0;
        gusterbought = false;
    }
}
