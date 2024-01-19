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

    public float cooldowntime = 2;
    public float ammotimer;
    public int maxammo = 5;
    public int currentammo;
    public float shoottimer;
    public float shootcooldown = 0.1f;

    Vector2 mousePos;

    public float slimeForce = 25f;

    //Update called at start
    private void Start()
    {
        currentammo = maxammo;
    }


    // Update is called once per frame
    void Update()
    {
        //Left Click
        if (Input.GetMouseButtonDown(0) && currentammo > 0 && shoottimer > shootcooldown)
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

            //Determines where the mouse position is
            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

            //TO DO ** Add Force
            Rigidbody2D rb = slimebeingfired.GetComponent<Rigidbody2D>();
            Vector2 playerpos = new Vector2(this.transform.position.x, this.transform.position.y);
            rb.AddForce((mousePos - playerpos).normalized * slimeForce, ForceMode2D.Impulse);

            //Explodes Slime
            Destroy(slimebeingfired, 0.5f);

            //Removes 1 from ammo counter
            currentammo --;

            //Resets shoot timer
            shoottimer = 0;
        }
        regenerateammo();

        shoottimer += Time.deltaTime;

    }

    void regenerateammo()
    {
        if(currentammo >= maxammo)
        {
            return;
        }
    if(ammotimer > cooldowntime)
        {
            currentammo ++;
            ammotimer = 0;
        }
        else
        {
            ammotimer = ammotimer + Time.deltaTime;
        }
    }

}