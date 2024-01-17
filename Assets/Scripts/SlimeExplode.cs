using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;




public class SlimeExplode : MonoBehaviour
{

    public GameObject slimesplat;
    private GameObject splat;

    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDestroy()
    {
        splat = Instantiate(slimesplat, transform.position, Quaternion.identity);
        splat.transform.rotation = transform.rotation;

        Destroy(splat, 0.5f);

    }
}
