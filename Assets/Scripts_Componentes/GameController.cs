using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private PlayerController _playerController;


    [Header("Player Settings")]

    public float movVelocity;
    public float limitMaxY;                
    public float limitMinY;
    public float limitMaxX;                
    public float limitMinX;
    public int Score;

    [Header("Bridge Settings")]

    public float objectVelocity;
    public float distanceToDestroy;
    public float bridgeSize;
    public GameObject PontePrefab;

    [Header("Barrel Settings")]

    public GameObject barrelPrefab;

    public float posYTop;    
    public float posYDown;
    public float barrelVelocity;
    public float cooldowSpawn;
    public float barrelDistanceToDestroy;
    public int barrelOrderTop;    
    public int barrelOrderDown;
    public int barrelDestroyed;

    [Header("Global Settings")]

    public float posXPlayer;
    public int barrelWave = 1;

    void Start()
    {
        StartCoroutine("spawnBarrel");
        _playerController = FindObjectOfType(typeof(PlayerController)) as PlayerController;
    }

    
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        posXPlayer= _playerController.transform.position.x;
    }

    IEnumerator spawnBarrel() // corrotina - Função que pode ser parada durante a sua propria execução e não funciona necessariamente pela atualização do update, ela possui um controle próprio.
    {
        yield return new WaitForSeconds(cooldowSpawn); //cooldown
        int rand = Random.Range(0, 100);
        int order = 0;
        float posY = 0;

        if( rand < 50)
        {
            posY = posYTop;
            order = barrelOrderTop;
            
        }
        else 
        {
            posY = posYDown;
            order = barrelOrderDown;                                 
            
        }



        GameObject temp = Instantiate(barrelPrefab); // spawn
        temp.transform.position = new Vector3(temp.transform.position.x, posY, 0);
        temp.GetComponent<SpriteRenderer>().sortingOrder = order;
        StartCoroutine("spawnBarrel"); // restart a coroutine

    }

    public void Scored( int currentScore)
    {
        Score += currentScore * barrelWave;
    }

    public void barrelWaveSystem(int currentWave)
    {
        barrelWave += currentWave;
        
    }
    public void changeScene(string destinationScene)
    {

        SceneManager.LoadScene(destinationScene);                    // faz o load de uma nova cena sem tela de loading (recomendado quando a cena é pequena e não tem risco de carregamento longo).
    }
}
