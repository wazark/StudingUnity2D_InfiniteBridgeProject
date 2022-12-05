using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [Header("Player Settings")]

    public float movVelocity;
    public float limitMaxY;                
    public float limitMinY;
    public float limitMaxX;                
    public float limitMinX;

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

    public int barrelOrderTop;    
    public int barrelOrderDow;

    void Start()
    {
        StartCoroutine("spawnBarrel");
    }

    
    void Update()
    {
        
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
            order = barrelOrderDow;                                 
            
        }



        GameObject temp = Instantiate(barrelPrefab); // spawn
        temp.transform.position = new Vector3(temp.transform.position.x, posY, 0);
        temp.GetComponent<SpriteRenderer>().sortingOrder = order;
        StartCoroutine("spawnBarrel"); // restart a coroutine

    }
}
