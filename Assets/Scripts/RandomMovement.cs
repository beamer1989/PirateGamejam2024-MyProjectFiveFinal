using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    float range;
    [SerializeField]
    float maxDistance;

    Vector2 waypoint;




    // Start is called before the first frame update
    void Start()
    {
        SetNewDestination();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoint, speed * Time.deltaTime);
        if(Vector2.Distance(transform.position, waypoint) < range )
        {
            SetNewDestination() ;
        }
    }

    void SetNewDestination()
    {
        Vector2 destination = new Vector2(Random.Range(-maxDistance, maxDistance), Random.Range(-maxDistance, maxDistance));
        Vector2 objectOrigin = new Vector2(this.transform.position.x, this.transform.position.y);
        waypoint = objectOrigin + destination;
    }
}
