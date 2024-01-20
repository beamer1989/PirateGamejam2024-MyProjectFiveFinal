using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject NPC_01;

    [SerializeField]
    private float spawnerInterval = 3.5f;


    private IEnumerator spawnNPC(float interval, GameObject NPC)
    {
        yield return new WaitForSeconds(interval);
        GameObject newNPC = Instantiate(NPC, this.transform.position + new Vector3(Random.Range(-5f, 5f), Random.Range(-6f, 6f), 0), Quaternion.identity);
        StartCoroutine(spawnNPC(interval, NPC_01));

    }


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnNPC(spawnerInterval, NPC_01));
    }

   
}