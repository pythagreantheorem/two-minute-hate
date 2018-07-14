using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuCreation : MonoBehaviour
{
    [SerializeField] private GameObject resumebut;
    [SerializeField] private GameObject shopbut;
    [SerializeField] private GameObject mainmenubut;
    [SerializeField] private GameObject howtobut;

    public void Menu(bool paused)
    {
        if (paused)
        {
            Debug.Log("Creating menu");
        }
        else
        {
            Debug.Log("Destroying menu");
            Destroy(resumebut);
        }
    }
}
