using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class componenteTransform : MonoBehaviour
{
    public Vector3 posicaoObjeto;
    void Start()
    {
        gameObject.name = "Imagem de Fundo"; // faz a alteração do nome do objeto (objeto volta a ter o nome original após finalização do play)
        gameObject.SetActive(false); /* desativa ou ativa o objeto. Digamos que ao coletar uma moeda queremos que esta moeda ao invez de ser destruida, apenas seja desativa, utilizamos o false para desativar, e true para ativar.
                                     Lembrando que outro objeto que estará ligado é quem fara o ligamento e desligamento. */
        
        gameObject.transform.position = posicaoObjeto; // posso mudar a posição diretamente com uma variavel do tipo vetor
        gameObject.transform.position = new Vector3(2, 1, 3); // ou posso colocar a informação do novo vetor diretamente no metodo.
        gameObject.transform.localScale = new Vector3(2, 2, 2); // podemos fazer o mesmo com o scale
        gameObject.transform.rotation = new Quaternion(1, 5, 7, 2); // no caso da rotação, ela é diferente do vetor, o quaterno necessita de 4 valores.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
