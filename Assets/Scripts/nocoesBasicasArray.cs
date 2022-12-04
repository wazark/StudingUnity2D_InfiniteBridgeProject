using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nocoesBasicasArray : MonoBehaviour
{
    public float[] mediaBimestral; //desta forma eu irei definir no inspector o tamanho da array. Se eu colocar o número dentro do colchetes este valor não pode ser processado. Dando o erro de que não pode ser especificado na declaração da array.
    
    void Start()
    {
        print(calculoFinal());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float calculoFinal()
    {
        float mediaFinal= (mediaBimestral[0] +mediaBimestral[1] +mediaBimestral[2] +mediaBimestral[3])/4;

        return mediaFinal;
    }
}
