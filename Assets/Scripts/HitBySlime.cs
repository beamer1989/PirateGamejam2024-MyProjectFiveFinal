using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBySlime : MonoBehaviour
{

    public GameObject slime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "slime") {
        
            Destroy(this.gameObject);

            Instantiate(slime, this.transform.position, Quaternion.identity);
        }
     
    }

    void Update()
    {
        
    }
}
