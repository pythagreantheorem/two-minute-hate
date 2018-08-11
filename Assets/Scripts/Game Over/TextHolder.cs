using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHolder : MonoBehaviour
{
    public Text goldtext;
    public Text killtext;

    public void SetText(string goalgold, string goalkill)
    {
        goldtext.text = goalgold;
        killtext.text = goalkill;
    }
}
