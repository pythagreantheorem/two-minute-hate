using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldDisplay : MonoBehaviour
{
    public int goldamount;
    public Text txt;

    public void DisplayGold()
    {
        string goaltxt = "Gold: " + goldamount;
        txt.text = goaltxt;
    }
    
    public void AddGold()
    {
        goldamount = goldamount + UnityEngine.Random.Range(1, 3);
    }

    private void Start()
    {
        goldamount = 0;
    }
}
