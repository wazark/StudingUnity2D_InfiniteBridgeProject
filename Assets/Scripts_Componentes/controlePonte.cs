using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlePonte : MonoBehaviour
{
    private GameController _gameController;
    private Rigidbody2D ponteRB;

    void Start()
    {
        
        _gameController=FindObjectOfType(typeof(GameController)) as GameController;
        ponteRB=GetComponent<Rigidbody2D>();

        ponteRB.velocity = new Vector2 (_gameController.objectVelocity, 0); //-7.28

    }

  
    void Update()
    {
        objectDestroy();

    }

    void objectDestroy()
    {
        if(transform.position.x <= _gameController.distanceToDestroy)
        {
            Destroy(gameObject);
        }
        

    }
}
