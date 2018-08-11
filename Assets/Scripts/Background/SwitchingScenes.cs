using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchingScenes : MonoBehaviour
{
    [SerializeField] private EnemySpawns enemyspwn;
    public int killcount;
    [SerializeField] private Display gameoverdisp;

    private void Start()
    {
        if(SceneManager.GetActiveScene().name == "1")
        {
            killcount = 0;
        }
    }
    public void AddKill()
    {
        killcount = killcount + 1;
        CheckLevelSwitch(killcount);
        this.GetComponent<GoldDisplay>().AddGold();
        gameoverdisp.addKill(killcount);
    }

    private void CheckLevelSwitch(int _killcount)
    {
        int spwnmax = 6;
        int spwnmin = 3;

        switch(_killcount)
        {
            case 5:
                spwnmax--;
                break;
            case 10:
                spwnmin--;
                break;
            case 15:
                spwnmax--;
                break;
            case 20:
                spwnmin--;
                break;
            case 25:
                spwnmax--;
                break;
        }
        enemyspwn._secsmax = spwnmax;
        enemyspwn._secsmin = spwnmin;
    }
}
