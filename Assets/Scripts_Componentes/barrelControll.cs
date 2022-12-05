using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelControll : MonoBehaviour
{
    private GameController _gameController;
    private Rigidbody2D barrelRB;

    private bool isSpawned;
    private int barrelDestroyed;
    private float distanceToDestroy = -3.629f;
    private float barrelVelocity;


    void Start()
    {
        _gameController = FindObjectOfType(typeof(GameController)) as GameController;

        barrelRB= GetComponent<Rigidbody2D>();
        barrelVelocity = _gameController.barrelVelocity;
        print(barrelVelocity);
        if(_gameController.barrelDestroyed >= 10)
        {
            _gameController.barrelVelocity += -0.3f;
            _gameController.barrelDestroyed = 0;
            _gameController.cooldowSpawn += -0.03f;
        }
        barrelRB.velocity = new Vector2(_gameController.barrelVelocity, 0);
    }

    
    void Update()
    {        
        barrelDestroy();        
    }

    

    void barrelDestroy()
    {
        if (transform.position.x <= distanceToDestroy)
        {
            Destroy(gameObject);            
            _gameController.barrelDestroyed += +1;            
            
        }
    }
}
