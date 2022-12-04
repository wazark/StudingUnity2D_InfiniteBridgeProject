using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manipularSpritRender : MonoBehaviour
{
    private SpriteRenderer sRender; // necessário inicializar o componente primeiro. Recomendado para evitar erros fazemos isto no private e usar o get component para evitar erros.



    void Start()
    {
       sRender = GetComponent<SpriteRenderer>(); // utilizamos o get componente e definimos o componente que queremos pegar. Poderiamos deixar a variavel publica e levar o componente até a variavel,
                                                 // mas podemos ter alguns erros com isto.

        //sRender.color = Color.red; // cores já pré definidas.
        sRender.color = new Color(255, 0, 0); // neste caso podemos utilizar os parametros RGB e colocar a cor que desejamos sem ser as pré definidas, mas o recomendado é a criação de uma
                                              // variável publica da cor que queremos e mudamos ela diretamente no inspector.
        sRender.flipX = true;
        sRender.enabled= true; // ativa ou desativa o componente. diferente do setactive que desativa o objet, este não faz isto, apenas o componente. 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
