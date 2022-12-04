using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leituradoArrayComLoops : MonoBehaviour
{
    public float[] fundamentoArray;
    void Start()
    {
        /* Utilizando o While:

        int indice =0; //variavel declarada 
        while (indice < fundamentoArray.Length) // enquanto indice for menor que o tamanho da variavel array, vai ficar executando a função do print mostrando em cada print o valor que foi definido na array. Ou seja, no 0 vai mostrar qual valor foi dado ao lenght 0.
        {
            
            print(fundamentoArray[indice]);
            indice +=1;
        }

        */

        /* Utilizando o For:

        for (int indice = 0; indice < fundamentoArray.Length; indice++)
        {
            print(fundamentoArray[indice]);
        }
        */

        //Utilizando o foreach
        
        foreach (float F in fundamentoArray)
        {
            // ou seja, a lógica escrita aqui vai agir em cada variavel dentro da Array fundamentos.

            print(F);

           if (fundamentoArray.Length > 6)
           {
            print("maior que 6");
           }
           else
           {
            print("menor que 6");
           }
            

        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
