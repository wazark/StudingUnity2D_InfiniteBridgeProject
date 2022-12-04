using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercicioLoops : MonoBehaviour
{
    public string nomeAluno;    
    public float[] mediaBimestral;


    void Start()
    {
        print("O aluno " + nomeAluno+ " teve media final " + mediaFinal(2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float mediaFinal(int modo)
    {
        
        float media=0;
        float mFinal=0;
        switch (modo)
        {
            
            case 0:
            int index=0;
            while (index < mediaBimestral.Length)            
        {
            media += mediaBimestral[index]; //CALCULO USANDO O WHILE.
            index ++;                                               
        }
            break;


            case 1:
            for (int i = 0; i < mediaBimestral.Length; i++)
        {            
            media += mediaBimestral[i];    // Calculo usando o For.
        }
            break;

            case 2:
            foreach (float mIndex in mediaBimestral)
        {
                        
            media += mIndex;   // ou seja, cada valor dentro da array vai ser somado e o valor total vai ser atribuido na variavel media. se temos 5 variaveis com valor igual a 5, então M vai ter o valor total de 25.
            // print("valor dentro desta index é de :" + mIndex);

        }
            
            
            break;
        }             
         

        
    mFinal = media / mediaBimestral.Length;
    return mFinal;


    }
}
