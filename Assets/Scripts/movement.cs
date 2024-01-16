using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;

    public int updog;


    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.W)) 
        //{
        //    Debug.Log("boop");
        //        }
        //kill me

        //why are we still here, just to suffer??
        Vector2 newPosition = this.transform.position;

        if (Input.GetKey(KeyCode.W))
        {
            newPosition.y += speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            newPosition.y -= speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            newPosition.x -= speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            newPosition.x += speed;
        }

        this.transform.position = newPosition;

        // owo whats this?? a cwomment??
    }
}