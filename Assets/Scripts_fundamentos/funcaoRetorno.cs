using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funcaoRetorno : MonoBehaviour
{
    public float val1;
    public float val2;
    public float val3;
    public float val4;
    public float val5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.End))
        {
            print(calculoTeste(0));

        }
    }

    bool verificaAprovacao(float media)
    {
        bool isAprovado = false;
        if(media >=7)
        {
            isAprovado= true;
        }

        return isAprovado;
    }

    float calculoTeste(float soma)
    {
        float equacao=(val1+val2)*val3+(val4/val2)/val5;
        soma += equacao;
        // (5+3)*8+(6+3)/7 = (8)*8+ (9)/7= 64+1.28
        return equacao;
    }
}
