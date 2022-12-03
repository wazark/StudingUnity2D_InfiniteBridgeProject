using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercicioMediaFinal : MonoBehaviour
{
    public string nomeAluno;
    public float mediaBimestreA;
    public float mediaBimestreB;
    public float mediaBimestreC;
    public float mediaBimestreD;
    private float mediaFinal;
    private bool isAprovado;
    private string statusAluno;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
           if(Input.GetKeyDown(KeyCode.Space))
           {
            calcularMediaFinal();
           }   
    }

    public void calcularMediaFinal()
    {

        mediaFinal=(mediaBimestreA + mediaBimestreB + mediaBimestreC + mediaBimestreD) / 4;
        if (mediaFinal>=7)
        {
            isAprovado = true;
            statusAluno = "APROVADO!";
            print(nomeAluno);
            print( mediaFinal);
            print(statusAluno);
            
        }
        else
        {
            isAprovado = false;
            statusAluno = "REPROVADO!";
            print(nomeAluno);
            print( mediaFinal);
            print(statusAluno);
        }
        
        
        
    }
}
