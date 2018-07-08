using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchingScenes : MonoBehaviour
{
    [SerializeField] private int killcount;

    public void AddKill()
    {
        killcount = killcount + 1;
        Debug.Log(killcount);
        CheckLevelSwitch(killcount);
    }

    private void CheckLevelSwitch(int _killcount)
    {
        Debug.Log("Checked");
    }
}
