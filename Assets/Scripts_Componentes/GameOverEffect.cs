using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameOverEffect : MonoBehaviour
{
    [Header("Cooldowns")]
    public float cooldownToShow;
    public float cooldownToScale;

    [Header("Objects")]
    public Canvas canvasImg;
    public Image frontImage;
    public Image shadowImage;
    private Rigidbody2D rBodyFront;
    private Rigidbody2D rBodyShadow;

    [Header("Vectors")]
    public Vector3 defaultScale;
    public Vector3 decrementScale;
    public Vector3 newScale;    

    void Start()
    {

        StartCoroutine("gameOverCooldown");        

        canvasImg.enabled = false;
        rBodyFront = GetComponent<Rigidbody2D>();
        rBodyShadow = GetComponent<Rigidbody2D>();

    }

    
    void Update()
    {
        
    }
    IEnumerator gameOverCooldown()
    {
        yield return new WaitForSeconds(cooldownToShow);

        if(canvasImg.enabled == false)
        {
            canvasImg.enabled = true;
        }
        yield return new WaitForSeconds(cooldownToShow * 1.2f);

        StartCoroutine("gameOverScale");
    }

        IEnumerator gameOverScale()
    {
        yield return new WaitForSeconds(cooldownToScale);

        if (frontImage.rectTransform.localScale != newScale  && shadowImage.rectTransform.localScale != newScale)
        {
            frontImage.rectTransform.localScale += decrementScale;
            shadowImage.rectTransform.localScale += decrementScale;
        }

        StartCoroutine("gameOverScale");
    }
       
    
}
