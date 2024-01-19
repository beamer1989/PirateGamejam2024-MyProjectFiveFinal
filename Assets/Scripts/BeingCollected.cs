using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeingCollected : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);

            Shoot playerComponent;
            playerComponent = collision.gameObject.GetComponent<Shoot>();
            int newAmmo = playerComponent.currentAmmo + 1;
            playerComponent.currentAmmo = newAmmo;

            
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
