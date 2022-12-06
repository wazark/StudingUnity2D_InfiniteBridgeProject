using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ButtonController : MonoBehaviour
{
    private GameOverEffect _gameOverEffect;
    public UnityEngine.UI.Button btnSelected;    
    private float cooldownToScale = 0.03f;
    public Vector3 defaultPosition;
    public Vector3 newScale;
    public Vector3 incrementScale;
    void Start()
    {
        
        _gameOverEffect =FindObjectOfType(typeof(GameOverEffect)) as GameOverEffect;
        StartCoroutine("btnEnableAndScaling");

        
        

    }

    
    void Update()
    {
        
    }
    IEnumerator btnEnableAndScaling()
    {
        yield return new WaitForSeconds(cooldownToScale);

        if (_gameOverEffect.isEnable == true)
        {
            _gameOverEffect.canvasBtn.enabled = true;

            if (btnSelected.transform.localScale != newScale)
            {
                gameObject.transform.localScale += incrementScale;
                
                StartCoroutine("btnEnableAndScaling");
            }
            else
            {
                print("parou");
            }
           
        }
        else
        {
            StartCoroutine("btnEnableAndScaling");
           
        }

    }
}
