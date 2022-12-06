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
    public Canvas canvasBtn;
    public Image frontImage;
    public Image shadowImage;
    public Button btnTitle;
    public Button btnResetGame;
    public Button btnQuitGame;
    private Rigidbody2D rBodyFront;
    private Rigidbody2D rBodyShadow;

    [Header("Vectors")]
    public Vector3 imgDefaultScale;
    public Vector3 imgDecrementScale;
    public Vector3 imgNewScale;

    [Header("Buttons")]
    public bool isEnable;
   
    public Vector3 btnIncrementScale;
    public Vector3 btnNewScale;

    void Start()
    {

        StartCoroutine("gameOverCooldown");
        //StartCoroutine("bntEnableAndScaling");

        
        rBodyFront = GetComponent<Rigidbody2D>();
        rBodyShadow = GetComponent<Rigidbody2D>();

        canvasBtn.enabled = false; 
        canvasImg.enabled = false;


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

        if (frontImage.rectTransform.localScale != imgNewScale  && shadowImage.rectTransform.localScale != imgNewScale)
        {
            frontImage.rectTransform.localScale += imgDecrementScale;
            shadowImage.rectTransform.localScale += imgDecrementScale;
        }

        StartCoroutine("gameOverScale");
    }
       
   
}
