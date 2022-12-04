using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funcaoRetorno : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.End))
        {
            print(verificaAprovacao(2));

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
}
