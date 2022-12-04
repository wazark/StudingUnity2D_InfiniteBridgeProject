using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limitarFPS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // a configuração do framerate é definida no metodo start. 

        Application.targetFrameRate= 60;  //podemos tanto ler quanto escrever. 

        QualitySettings.vSyncCount= 0; //Para funcionar corretamente esta função, é necessário desligar o vsync (sincronização vertical). Se desligar o Vsync sem aplicar uma taxa do fps, o FPS vai para acima de 3000.



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
