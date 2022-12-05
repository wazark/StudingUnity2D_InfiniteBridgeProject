using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class FlipCharacterAndShadow : MonoBehaviour
{
    private SpriteRenderer sRender;
    public GameObject parentObject;
    public bool isShadow;
    public Vector3 shadowFrontPosition;
    public Vector3 shadowBackPosition;
    public Vector3 parentPosition;

    void Start()
    {
        sRender= GetComponent<SpriteRenderer>();
        //parentPosition = parentObject.transform.position;
        
    }

    
    void Update()
    {
        characterFlip();
        parentPosition = parentObject.transform.position;
    }
    void characterFlip()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");


        if (horizontal < 0)
        {
            sRender.flipX= true;
            if(isShadow == true) 
            {
                gameObject.transform.position = parentPosition + shadowBackPosition;
            }
           
        }
        else
        {
            sRender.flipX = false;
            if (isShadow == true)
            {
                gameObject.transform.position = parentPosition + shadowFrontPosition;
            }
        }
    }
}
