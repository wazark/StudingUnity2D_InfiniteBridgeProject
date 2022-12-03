using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controleFluxoSwitch : MonoBehaviour
{
    public int diaSemana;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            diasDaSemana();
        }
    }
    public void diasDaSemana()
    {
      switch (diaSemana)
      {
        default: 
        print ("Dia da Semana Inválido");
        break;
        case 0:
        print ("Domingo");
        break;
        case 1:
        print ("Segunda");
        break;
        case 2:
        print ("Terça");
        break;
        case 3:
        print ("Quarta");
        break;
        case 4:
        print ("Quinta");
        break;
        case 5:
        print ("Sexta");
        break;
        case 6:
        print ("Sábado");
        break;
      }  
    }
}
