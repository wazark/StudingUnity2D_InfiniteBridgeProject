using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelControll : MonoBehaviour
{
    private GameController _gameController;
    private Rigidbody2D barrelRB;

    private bool isSpawned;
    private int barrelDestroyed;


    void Start()
    {
        _gameController = FindObjectOfType(typeof(GameController)) as GameController;

        barrelRB= GetComponent<Rigidbody2D>();

        barrelRB.velocity = new Vector2(_gameController.barrelVelocity, 0);
    }

    
    void Update()
    {        
        barrelDestroy();
        if(barrelDestroyed >= 10)
        {
            barrelDestroyed= 0;
            barrelRB.velocity = new Vector2(_gameController.barrelVelocity + -1.0f, 0);
            print("aumentou as velocidade");
        }
    }

    

    void barrelDestroy()
    {
        if (transform.position.x <= _gameController.distanceToDestroy)
        {
            Destroy(gameObject);
            barrelDestroyed++;
        }
    }
}
