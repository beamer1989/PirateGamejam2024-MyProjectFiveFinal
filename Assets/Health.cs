using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    public int health = 10;
    public int currentiframe = 60;
    public int maxiframes = 60;

    public GameObject healthBar;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ENEMY00")
        {
            if (currentiframe == maxiframes)
            { 
                currentiframe = 1;
                health = health - 1;
                healthBar.GetComponent<Slider>().value = health;
                
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
            print("dead");
        }
    }
}
