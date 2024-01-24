using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public int killpoint = 100;
    public int currentkill = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentkill >= killpoint)
        {
            SceneManager.LoadScene(4);
        }
    }
}
