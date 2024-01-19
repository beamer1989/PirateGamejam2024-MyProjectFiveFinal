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

    public float regenTimer = 2;
    private float regenTimeCounter;
    public int maxRegenAmmo = 5;
    public int currentAmmo;
    private float shootTimeCounter;
    public float shootCooldownTime = 0.1f;
  

    Vector2 mousePos;

    public float slimeForce = 25f;

    //Update called at start
    private void Start()
    {
        currentAmmo = maxRegenAmmo;
        cam = Camera.main;
    }


    // Update is called once per frame
    void Update()
    {
        //Left Click
        if (Input.GetMouseButtonDown(0) && currentAmmo > 0 && shootTimeCounter > shootCooldownTime)
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
            currentAmmo --;

            //Resets shoot timer
            shootTimeCounter = 0;
        }
        regenerateammo();

        shootTimeCounter += Time.deltaTime;

    }

    void regenerateammo()
    {
        if(currentAmmo >= maxRegenAmmo)
        {
            return;
        }
    if(regenTimeCounter > regenTimer)
        {
            currentAmmo ++;
            regenTimeCounter = 0;
        }
        else
        {
            regenTimeCounter = regenTimeCounter + Time.deltaTime;
        }
    }

}