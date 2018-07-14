using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchingScenes : MonoBehaviour
{
    public int killcount;
    [SerializeField] private GoldDisplay _goldDisplay;

    private void Start()
    {
        killcount = 0;
    }
    public void AddKill()
    {
        killcount = killcount + 1;
        CheckLevelSwitch(killcount);
        _goldDisplay.DisplayGold(killcount);
    }

    private void CheckLevelSwitch(int _killcount)
    {
        switch(_killcount)
        {
            case 5:

                //SceneManager.LoadScene("SampleScene");
            break;
        }

    }
}
