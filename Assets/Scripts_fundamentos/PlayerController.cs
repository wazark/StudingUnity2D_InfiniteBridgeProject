using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D PlayerRigidBody;
    private SpriteRenderer sRender;
    private GameController _GameController;
    
    


    void Start()
    {
        Application.targetFrameRate = 60;  
        QualitySettings.vSyncCount = 0;


        PlayerRigidBody = GetComponent<Rigidbody2D>();
        sRender = GetComponent<SpriteRenderer>();      
        
        _GameController=FindObjectOfType(typeof(GameController)) as GameController; // acessa a outra classe e faz a conversão.
    }
        
    void Update()
    {
        movimentation();
        
    }

    void movimentation()
    {
        
        float horizontal = Input.GetAxisRaw("Horizontal"); // atribuimos às variaveis horizontal e vertical os valores pegos no AxisRaw.
        float vertical = Input.GetAxisRaw("Vertical");
        PlayerRigidBody.velocity = new Vector2(horizontal * _GameController.movVelocity, vertical * _GameController.movVelocity); // o vetor do transform do objeto irá mudar conforme altera as variaveis antes criadas.

        float posY = transform.position.y;    // criamos 2 variáveis as quais vão herdar o valor atual da posição do transform X e Y
        float posX = transform.position.x;

        // Limit of Movimentation X
        if (transform.position.x > _GameController.limitMaxX)
        {
            posX = _GameController.limitMaxX;
        }
        else if (transform.position.x < _GameController.limitMinX)
        {
            posX = _GameController.limitMinX;
        }

        // Limit of Movimentation Y
        if (transform.position.y > _GameController.limitMaxY)       // fazemos um check para verificar se a posição atual é maior que o limite pré definido. Caso seja, a variavél  de posição muda para o valor limite. 
        {
            posY = _GameController.limitMaxY;

        }
        else if (transform.position.y < _GameController.limitMinY)
        {
            posY = _GameController.limitMinY;

        }

        transform.position = new Vector3(posX, posY, 0); // define que a nova posição do transform será com base no valor das variáveis criadas anteriormente.

        
    }

    void OnTriggerEnter2D()
    {        
        Debug.LogError("GameOver");
        
    }
}  
    
    

