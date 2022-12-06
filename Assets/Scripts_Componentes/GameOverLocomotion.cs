using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverLocomotion : MonoBehaviour
{
    public float newPosition;
    public float velocity;
    private GameOverEffect _gameOverEffect;

    private Rigidbody2D rBody;

    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        _gameOverEffect = FindObjectOfType(typeof(GameOverEffect)) as GameOverEffect;

        StartCoroutine("locomotionStart");
        StartCoroutine("locomotionStop");
    }
    

    IEnumerator locomotionStop()
    {
        yield return new WaitForSeconds(_gameOverEffect.cooldownToScale);

        if (gameObject.transform.position.y >= newPosition)
        {
            rBody.velocity= new Vector2 (0,0);
            _gameOverEffect.isEnable= true;
        }
        else
        {            
            StartCoroutine("locomotionStop");
        }

    }

    IEnumerator locomotionStart()
    {
        yield return new WaitForSeconds(_gameOverEffect.cooldownToScale);

        if (this.transform.localScale == _gameOverEffect.imgNewScale)
        {
            rBody.velocity = new Vector2(0, velocity);  
        }
        else
        {
            StartCoroutine("locomotionStart");
        }
    }
}

