using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Shoot : MonoBehaviour
{
    public GameObject slime;
    private GameObject slimebeingfired;
    public Camera cam;

    Vector2 mousePos;

    // Update is called once per frame
    void Update()
    {
        //Left Click
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse 0 - Left Click");

            // Gets the Mouse Position
            // (0, 0) at the bottom left
            // (width, height) at the top right
            Debug.Log(Input.mousePosition);
            //ScreentoWorldPoint to get the World Coordinates
            Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition));

            //Spawn Slime
            slimebeingfired = Instantiate(slime, transform.position, Quaternion.identity);

            //Rotate Slime
            var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
            var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            slimebeingfired.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
           
            //TO DO ** Add Force

            //Determines where the mouse position is
            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        }
    }
    //void FixedUpdate()
    //{
    //    Vector2 lookDir = mousePos - rb.position;
    //    float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;

    //}
        
}