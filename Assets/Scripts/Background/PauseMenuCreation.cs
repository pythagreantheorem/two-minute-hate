using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuCreation : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    [SerializeField] private GameObject resumebut;
    [SerializeField] private GameObject shopbut;
    [SerializeField] private GameObject mainmenubut;
    [SerializeField] private GameObject howtobut;

    public void Menu(bool paused)
    {
        if (paused)
        {
            Instantiate(resumebut, canvas.transform);
            Instantiate(shopbut, canvas.transform);
            Instantiate(mainmenubut, canvas.transform);
            Instantiate(howtobut, canvas.transform);

        }
        else
        {
            Destroy(GameObject.Find("ResumeBut(Clone)"));
            Destroy(GameObject.Find("ShopBut(Clone)"));
            Destroy(GameObject.Find("MainMenuBut(Clone)"));
            Destroy(GameObject.Find("HowToPlayButton(Clone)"));
        }
    }
}
