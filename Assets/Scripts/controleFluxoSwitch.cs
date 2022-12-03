using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controleFluxoSwitch : MonoBehaviour
{
    public string comandos;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            comandos +="E ";
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            comandos +="D ";
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            comandos +="C ";
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            comandos +="B ";
        }

        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            executaComando();
        }
    }
 void executaComando()
{
    switch (comandos)
    {
        
        default:
        print("Combo errado");
        break;

        case "B D D ":
        print( "haduken!");
        break;

        case "B C C ":
        print( "Shariuken!");
        break;

        case "E E D D C D ":
        print( "Katasiseruken!");
        break;
        
    }

    comandos="";
}  
}
