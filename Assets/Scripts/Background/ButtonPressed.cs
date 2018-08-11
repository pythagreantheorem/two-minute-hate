using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPressed : MonoBehaviour
{
    public void HowTo()
    {
        if (SceneManager.GetActiveScene().name != "Title Screen")
        {
            GameObject.Find("LevelRunning").GetComponent<Pause>().StopGame();
        }
        SceneManager.LoadScene("HowTo1");
    }

    public void Play()
    {
        SceneManager.LoadScene("1");
    }

    //Pause Menu Buttons
    public void MainMenu()
    {
        GameObject.Find("LevelRunning").GetComponent<Pause>().StopGame();
        SceneManager.LoadScene("Title Screen");
    }

    public void EnterExitShop()
    {
        GameObject.Find("LevelRunning").GetComponent<ShopMenuCreation>().CreateDestroyPauseMenu();
    }

    public void Unpause()
    {
        GameObject.Find("LevelRunning").GetComponent<Pause>().StopGame();
    }

    public void GameOverMainMenu()
    {
        SceneManager.LoadScene("Title Screen");
    }

    //Shop Menu Buttons
    public void BuyItems()
    {
        GameObject.Find("Shop Runner").GetComponent<ShopActionController>().BuyItems();
    }
}
