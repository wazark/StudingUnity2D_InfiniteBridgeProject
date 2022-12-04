using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Estudo dos loops while e for. utilizando a mesma lógica porém executados de forma diferentes.
public class Loops : MonoBehaviour
{
    int contagemWhile = 100; // variavel será usada no while
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {         
        
        while (contagemWhile >0)
        {
            contagemWhile-= 1;
            print(contagemWhile);
        }

        }

        if (Input.GetKeyDown(KeyCode.End))
        {
            for (int contagemFor = 0; contagemFor < 100; contagemFor++) // no caso como vai ser add 1 em 1, estou utilizando o ++. caso fosse de 2 em 2, poderia usar += 2.
            {
                print(contagemFor);
            }
        }




    }

    
}
