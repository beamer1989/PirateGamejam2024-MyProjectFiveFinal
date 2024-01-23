using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AmmoCount1 : MonoBehaviour
{
    public GameObject PlayerCharacter;
    public GameObject SlimeAmmo1;
    public GameObject SlimeAmmo2;
    public GameObject SlimeAmmo3;
    public GameObject SlimeAmmo4;
    public GameObject SlimeAmmo5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //1
        if (PlayerCharacter.GetComponent<Shoot>().currentAmmo > 0)
        {
            SlimeAmmo1.GetComponent<Image>().enabled = true;
        }
        else
        {
            SlimeAmmo1.GetComponent<Image>().enabled = false;
        }
        Debug.Log(PlayerCharacter.GetComponent<Shoot>().currentAmmo);
        //2
        if (PlayerCharacter.GetComponent<Shoot>().currentAmmo > 1)
        {
            SlimeAmmo2.GetComponent<Image>().enabled = true;
        }
        else
        {
            SlimeAmmo2.GetComponent<Image>().enabled = false;
        }
        Debug.Log(PlayerCharacter.GetComponent<Shoot>().currentAmmo);
        //3
        if (PlayerCharacter.GetComponent<Shoot>().currentAmmo > 2)
        {
            SlimeAmmo3.GetComponent<Image>().enabled = true;
        }
        else
        {
            SlimeAmmo3.GetComponent<Image>().enabled = false;
        }
        Debug.Log(PlayerCharacter.GetComponent<Shoot>().currentAmmo);
        //4
        if (PlayerCharacter.GetComponent<Shoot>().currentAmmo > 3)
        {
            SlimeAmmo4.GetComponent<Image>().enabled = true;
        }
        else
        {
            SlimeAmmo4.GetComponent<Image>().enabled = false;
        }
        Debug.Log(PlayerCharacter.GetComponent<Shoot>().currentAmmo);
        //5
        if (PlayerCharacter.GetComponent<Shoot>().currentAmmo > 4)
        {
            SlimeAmmo5.GetComponent<Image>().enabled = true;
        }
        else
        {
            SlimeAmmo5.GetComponent<Image>().enabled = false;
        }
        Debug.Log(PlayerCharacter.GetComponent<Shoot>().currentAmmo);
    }
}
