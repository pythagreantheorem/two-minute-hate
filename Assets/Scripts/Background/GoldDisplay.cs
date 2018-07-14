using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldDisplay : MonoBehaviour
{
    public Text txt;

    public void DisplayGold(int goldcount)
    {
        string goldamount = goldcount.ToString();
        Debug.Log(goldamount);
        string newtxt = "Gold:" + goldamount;
        //txt.text = newtxt;
    }
}
