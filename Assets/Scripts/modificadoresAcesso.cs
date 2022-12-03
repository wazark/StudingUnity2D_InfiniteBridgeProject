using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modificadoresAcesso : MonoBehaviour
{
    

    //modificadores    tipo     nome
    public string nomeAluno;
    public int idadeAluno;
    public bool isAprovado;
    public float mediaBimestreA;
    public float mediaBimestreB;
    public float mediaBimestreC;
    public float mediaFinal;


    //Tipos de de modificadores de acesso:

    public int valor =0;        // o acesso utilizando o public não deixa restrito.
                                // Public e Privado são os modificadores mais usados.
    private int valor2=1;       // este valor fica restrito apenas para a classe que o valor pertence! O fato se a variável é publica ou variável, não mudará nada se o jogo vai ser hackeado ou não. 
                                //É apenas forma de interpretação dentro da memória. Os valores poderão ser modificados do mesmo jeito. Geralmente usamos isto quando queremos quando somente seja executado por um script específico. 

    protected int valor3=2;
    internal int valor4=3;    // estes outros modificadores de acesso são usados mais em herança e name space (as bibliotecas no using).
    protected internal int valor5=4;
    private protected int valor6=5;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
