using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fundamentosMovimentacao : MonoBehaviour
{
    private Rigidbody2D PlayerRigidBody;
    private SpriteRenderer sRender;
    
    public float movVelocity;
    public float limitMaxY;                // variaveis limitadoras de posição vertical.
    public float limitMinY;
    public float limitMaxX;                // variaveis limitadoras de posição horizontal.
    public float limitMinX;


    void Start()
    {
        Application.targetFrameRate = 60;  
        QualitySettings.vSyncCount = 0;


        PlayerRigidBody = GetComponent<Rigidbody2D>();
        sRender = GetComponent<SpriteRenderer>();        
    }
        
    void Update()
    {
        movimentation();
        characterFlip();
    }

    void movimentation()
    {
        
        float horizontal = Input.GetAxisRaw("Horizontal"); // atribuimos às variaveis horizontal e vertical os valores pegos no AxisRaw.
        float vertical = Input.GetAxisRaw("Vertical");
        PlayerRigidBody.velocity = new Vector2(horizontal * movVelocity, vertical * movVelocity); // o vetor do transform do objeto irá mudar conforme altera as variaveis antes criadas.

        float posY = transform.position.y;    // criamos 2 variáveis as quais vão herdar o valor atual da posição do transform X e Y
        float posX = transform.position.x;

        // Limit of Movimentation X
        if (transform.position.x > limitMaxX)
        {
            posX = limitMaxX;
        }
        else if (transform.position.x < limitMinX)
        {
            posX = limitMinX;
        }

        // Limit of Movimentation Y
        if (transform.position.y > limitMaxY)       // fazemos um check para verificar se a posição atual é maior que o limite pré definido. Caso seja, a variavél  de posição muda para o valor limite. 
        {
            posY = limitMaxY;

        }
        else if (transform.position.y < limitMinY)
        {
            posY = limitMinY;

        }

        transform.position = new Vector3(posX, posY, 0); // define que a nova posição do transform será com base no valor das variáveis criadas anteriormente.

    }

    void characterFlip()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        if(horizontal < 0)
        {
            sRender.flipX = true;
        }
        else
        {
            sRender.flipX = false;
        }
    }

}  
    
    

