using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldDisplay : MonoBehaviour
{
    public Text txt;

    public void DisplayGold(int goldcount)
    {
        string newtxt = "Gold:" + goldcount.ToString();
        Debug.Log(newtxt);
    }
}
