using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteChange : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;
    public Sprite newSprite;

    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            newSprite = spriteArray[0];
            ChangeSprite();
        }

        if (Input.GetKey(KeyCode.S))
        {
            newSprite = spriteArray[1];
            ChangeSprite();

        }

        if (Input.GetKey(KeyCode.A))
        {
            newSprite = spriteArray[2];
            ChangeSprite();

        }

        if (Input.GetKey(KeyCode.D))
        {
            newSprite = spriteArray[3];
            ChangeSprite();

        }
    }
}
