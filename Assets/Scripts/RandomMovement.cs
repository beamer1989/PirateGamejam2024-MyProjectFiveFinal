using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class RandomMovement : MonoBehaviour
{
    //FOR ANIMATIONS:
    public Animator animator;
    Vector2 movement;
    Vector2 lastposition;

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

        lastposition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoint, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, waypoint) < range)
        {
            SetNewDestination();
        }

        //Detect movement for animation
        movement.x = transform.position.x - lastposition.x;
        movement.y = transform.position.y - lastposition.y;
        movement.Normalize();

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        lastposition = transform.position;
    }

    void SetNewDestination()
    {
        Vector2 destination = new Vector2(Random.Range(-maxDistance, maxDistance), Random.Range(-maxDistance, maxDistance));
        Vector2 objectOrigin = new Vector2(this.transform.position.x, this.transform.position.y);
        waypoint = objectOrigin + destination;
    }
}
