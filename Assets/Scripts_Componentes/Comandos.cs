using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Comandos : MonoBehaviour
{
   
   public void goTo(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void quitGame() 
    {
        Application.Quit(); 
    }

    
}
