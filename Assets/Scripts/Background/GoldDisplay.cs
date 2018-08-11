using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoldDisplay : MonoBehaviour
{
    public int goldamount;
    public Text txt;
    [SerializeField] private Display gameoverdisp;

    public void DisplayGold()
    {
        string goaltxt = "Gold: " + goldamount;
        txt.text = goaltxt;
    }
    
    public void AddGold()
    {
        goldamount = goldamount + UnityEngine.Random.Range(1, 3);
        gameoverdisp.addGold(goldamount);
    }

    private void Start()
    {
        if(SceneManager.GetActiveScene().name == "1")
        {
            goldamount = 0;
        }
    }
}
