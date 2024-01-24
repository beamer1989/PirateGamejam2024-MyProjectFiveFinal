using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcKillPoint : MonoBehaviour
{
    public WinCondition WinCondition;
    private void OnDestroy()
    {
        WinCondition.currentkill = WinCondition.currentkill + 1;

        if (WinCondition != null)
        {

        }
    }

}
