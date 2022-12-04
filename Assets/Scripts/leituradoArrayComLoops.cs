using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leituradoArrayComLoops : MonoBehaviour
{
    public float[] fundamentoArray;
    void Start()
    {
        
        int indice =0; //variavel declarada 
        while (indice < fundamentoArray.Length) // enquanto indice for menor que o tamanho da variavel array, vai ficar executando a função do print mostrando em cada print o valor que foi definido na array. Ou seja, no 0 vai mostrar qual valor foi dado ao lenght 0.
        {
            
            print(fundamentoArray[indice]);
            indice +=1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
