using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchingScenes : MonoBehaviour
{
    public int killcount;

    private void Start()
    {
        killcount = 0;
    }
    public void AddKill()
    {
        killcount = killcount + 1;
        CheckLevelSwitch(killcount);
        this.GetComponent<GoldDisplay>().AddGold();
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
