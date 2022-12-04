using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class fundamentosINPUTS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Inputs que retornam valores boleanos

       /* if (Input.GetButton("Fire1"))
        {
            print("Apertando o botão fire1");  // Este modo enquanto estiver apertando o botão, a lógica vai ser executada a cada frame.
        }
       */
        if(Input.GetButtonDown("Fire1"))
        {
            print("Apertei o botão fire1"); // Esta lógica irá executar uma única vez, mesmo que eu mantenha o botão apertado.             
        }

        if(Input.GetButtonUp("Fire1"))
        {
            print("Soltei o botão fire1"); // Este método igualmente ao anterior, irá ser executado uma única vez a cada ação feita. ou seja, se soltar o botão, vai ser feito uma unica vez, se apertar o botão e soltar novamente, sera executado uma única vez novamente.
        }

        // Inputs que retornam valores float

        
          //  print(Input.GetAxis("Horizontal")); // É sensivel ao analógico. Desta forma ele vai de 0 a +1 ou 0 a -1.
        
        
        
           print(Input.GetAxisRaw("Vertical")); // não é sensivel ao analógico. Vai dar resultado 0 ou 1 / 0 ou -1.
        

        // Podemos utilizar estes valores do GetAxis para multiplicar ao valor de velocidade de movimento de um personagem.

        //E quando o jogo é específico para computador e é necessário configurar várias téclas, podemos utilizar o Keycode, como nos estudos passados.


        if(Input.GetKeyDown(KeyCode.Escape)) // também possui o getkey UP e GetKey como os demais exemplos
        {
            print("Apertei Esc");
        }

        // E para o Mouse, podemos usar:

        if(Input.GetMouseButtonDown(1)) // colocamos no valor intege o botão que for pressionado (0 - Esquerda, 1 Direita e 2 Scroll do mouse (para saber que apertou e não que rodou o scroll)). E também possui o GetMouseButton UP e GetMouseButton.
        {
            print("apertei o botao 1");
        }


    }
}
