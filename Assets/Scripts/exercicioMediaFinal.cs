using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercicioMediaFinal : MonoBehaviour
{
    public string nomeAluno;
    public int mediaBimestreA;
    public int mediaBimestreB;
    public int mediaBimestreC;
    public int mediaBimestreD;
    private float mediaFinal;
    private bool isAprovado;
    private string statusAluno;

    void Start()
    {
        calcularMediaFinal();

        if(mediaFinal >= 6)
        {
            isAprovado= true;
            statusAluno= "APROVADO!";
            print(statusAluno);
        }
        else
        {
            isAprovado= false;
            statusAluno="Reprovado!";
            print(statusAluno);
        }
    }

    // Update is called once per frame
    void Update()
    {
              
    }

    public void calcularMediaFinal()
    {

        mediaFinal=(mediaBimestreA + mediaBimestreB + mediaBimestreC + mediaBimestreD) / 4;
        print( mediaFinal);

    }
}
