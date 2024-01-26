using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Health : MonoBehaviour
{
    public int health = 10;
    public int currentiframe = 60;
    public int maxiframes = 60;

    public HealthBarScript healthBar;
    public AudioSource damageSound;

    // Start is called before the first frame update
    void Start()
    {
        healthBar.SetMaxHealth(health); 
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ENEMY00")
        {
            if (currentiframe == maxiframes)
            { 
                currentiframe = 1;
                health = health - 1;
                healthBar.SetHealth(health);
                damageSound.Play();
            }
        
         
            
        }

    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        if(currentiframe < maxiframes)
        {
            currentiframe = currentiframe + 1;
        }
        
    }
    void Update()
    {
        if (health == 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
