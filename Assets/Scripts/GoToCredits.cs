using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToCredits : MonoBehaviour
{

    private int countDownTimer = 0;
    private int targetTime = 150;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        countDownTimer++;

        if (countDownTimer >= targetTime)
        {
            SceneManager.LoadScene(5);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
