using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Display : MonoBehaviour
{
    public int totalgold;
    public int totalkills;
    public bool gameoverscene;

    private void Awake()
    {
        gameoverscene = false;
        DontDestroyOnLoad(this.gameObject);
    }

    void Update ()
    {
        if (SceneManager.GetActiveScene().name == "GameOver" && gameoverscene == false)
        {
            //Set up text strings
            string goalGold = "Total Gold: " + totalgold;
            string goalKill = "Total Kills: " + totalkills;
            GameObject.Find("HoldingText").GetComponent<TextHolder>().SetText(goalGold, goalKill);
            gameoverscene = true;
        }
	}

    public void addGold(int currentgold)
    {
        totalgold = currentgold;
    }

    public void addKill(int currentkills)
    {
        totalkills = currentkills;
    }
}