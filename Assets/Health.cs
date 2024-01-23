using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "slime")
        {

            Destroy(this.gameObject);

            Instantiate(slime, this.transform.position, Quaternion.identity);
        }

    }
    */
    // Update is called once per frame
    void Update()
    {
        
    }
}
