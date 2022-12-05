using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlePonte : MonoBehaviour
{
    private GameController _gameController;
    private Rigidbody2D ponteRB;

    private bool isSpawned;

    void Start()
    {
        
        _gameController=FindObjectOfType(typeof(GameController)) as GameController;
        ponteRB=GetComponent<Rigidbody2D>();

        ponteRB.velocity = new Vector2 (_gameController.objectVelocity, 0); //-7.28

    }

  
    void Update()
    {
        objectDestroy();
        objectSpawn();

    }

    void objectSpawn()
    {
        if(isSpawned == false) 
        {
            if(transform.position.x <= 0)
            {
                isSpawned= true;
                GameObject temp = Instantiate(_gameController.PontePrefab);
                float posX = transform.position.x + _gameController.bridgeSize;
                float posY = transform.position.y;
                temp.transform.position = new Vector3(posX,posY,0);
            }
        }

    }


    void objectDestroy()
    {
        if(transform.position.x <= _gameController.distanceToDestroy)
        {
            Destroy(gameObject);
        }
        

    }
}
