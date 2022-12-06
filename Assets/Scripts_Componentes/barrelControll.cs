using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelControll : MonoBehaviour
{
    private GameController _gameController;
    private Rigidbody2D barrelRB;

    private bool isSpawned;
    private int barrelDestroyed;
    
    private float barrelVelocity;
    private bool scored;


    void Start()
    {
        _gameController = FindObjectOfType(typeof(GameController)) as GameController;

        barrelRB= GetComponent<Rigidbody2D>();
        barrelVelocity = _gameController.barrelVelocity;
        
        if(_gameController.barrelDestroyed >= 10)
        {
            _gameController.barrelVelocity += -0.3f;
            _gameController.barrelDestroyed = 0;
            _gameController.cooldowSpawn += -0.03f;
            _gameController.barrelWaveSystem(1);
        }
        barrelRB.velocity = new Vector2(_gameController.barrelVelocity, 0);
    }

    
    void Update()
    {        
        barrelDestroy();        
    }

    private void LateUpdate()
    {
        if(scored == false && transform.position.x < _gameController.posXPlayer) 
        {            
         scored= true;
            _gameController.Scored(10);
        }
    }

    void barrelDestroy()
    {
        if (transform.position.x <= _gameController.barrelDistanceToDestroy)
        {
            Destroy(gameObject);
            _gameController.barrelDestroyed += 1;
        }
    }
}
