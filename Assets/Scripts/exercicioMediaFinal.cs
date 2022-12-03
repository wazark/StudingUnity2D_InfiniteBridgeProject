using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercicioMediaFinal : MonoBehaviour
{
    public string nomeAluno;
    private string statusAluno;
    public float mediaBimestreA;
    public float mediaBimestreB;
    public float mediaBimestreC;
    public float mediaBimestreD;    
    private float mediaNecessaria = 7;
    public int frequencia;    
    private int frequenciaNecessaria= 80;
    public bool isAprovado;
    
    

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

        float mediaFinal=(mediaBimestreA + mediaBimestreB + mediaBimestreC + mediaBimestreD) / 4;

        if (mediaFinal>=mediaNecessaria && frequencia >= frequenciaNecessaria)
        {
            statusAluno = "APROVADO";
            isAprovado = true;
            print("O Aluno " + nomeAluno + " foi " + statusAluno + " com média final " + mediaFinal + " e frequencia de " + frequencia + "%" );
        }
        else if(mediaFinal>=mediaNecessaria && frequencia < frequenciaNecessaria)
        {
            statusAluno ="REPROVADO POR FATAS";
            isAprovado = false;
            print("O Aluno " + nomeAluno + " foi " + statusAluno + " com média final " + mediaFinal + " e frequencia de " + frequencia + "%" );
        }
        else if (mediaFinal<=mediaNecessaria && frequencia >= frequenciaNecessaria)
        {
            statusAluno ="REPROVADO POR NOTAS";
            isAprovado = false;
            print("O Aluno " + nomeAluno + " foi " + statusAluno + " com média final " + mediaFinal + " e frequencia de " + frequencia + "%" );
        }
        else if(mediaFinal<=mediaNecessaria && frequencia <= frequenciaNecessaria)
        {
            statusAluno ="REPROVADO POR FALTAS E POR NOTAS";
            isAprovado = false;
            print("O Aluno " + nomeAluno + " foi " + statusAluno + " com média final " + mediaFinal + " e frequencia de " + frequencia + "%" );
        }
        
        
        
    }
}
