using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCanimator : MonoBehaviour
{
    public Animator animator;
    Vector2 movement;
    Vector2 lastposition;

    // Start is called before the first frame update
    void Start()
    {
        lastposition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Detect movement for animation
        movement.x = transform.position.x - lastposition.x;
        movement.y = transform.position.y - lastposition.y;
        movement.Normalize();

        if (transform.position.x != lastposition.x && transform.position.y != lastposition.y)
        {
            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Speed", movement.sqrMagnitude);
        }
        lastposition = transform.position;
    }
}
