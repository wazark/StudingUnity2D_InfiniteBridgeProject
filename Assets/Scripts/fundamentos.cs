using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fundamentos : MonoBehaviour
{
    /*declaramos as variáveis aqui.
    A ordem que executamos é chamado de Fluxo.
    as variáveis ficam: tipoInformação    nomeVariável        
     */

    //Tipos de variáveis:
    int inteiro = 100;                // uma variável do tipo int armazena números inteiros, seja negativo ou positivo,
                                      // ela também possui um limite máximo de valor: -2.147.483.648 até 2.147.483.648.

    float flutuante = 1.5f;            // ponto flutuante, número com casas decimais, porém usamos o PONTO como separador
                                       // e não a vírgula. Necessário colocar o f na frente do valor para identificar que é float. O valor máximo +e 10^(elevado a)38.

    bool isBoleano = true;              // valor lógico, só tem 2 possíveis retornos. Verdadeiro ou Falso. por boa prática toda variável bool começa com "is".

    string texto = "Hello World 1.0";  // O string armazena qualquer valor alpha numérico, desde que esteja dentro das aspas. 

    // Start is called before the first frame update
    void Start() // são chamados de métodos ou funções. 
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
