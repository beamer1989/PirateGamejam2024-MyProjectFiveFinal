using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcKillPoint : MonoBehaviour
{
    public GameObject targetWinCondition;
    public WinCondition WinCondition;

    private void Awake()
    {

        targetWinCondition = GameObject.Find("WinCondition");
        WinCondition = targetWinCondition.GetComponent<WinCondition>();


    }

    private void OnDestroy()
    {
        WinCondition.currentkill = WinCondition.currentkill + 1;

        if (WinCondition != null)
        {

        }
    }

}
