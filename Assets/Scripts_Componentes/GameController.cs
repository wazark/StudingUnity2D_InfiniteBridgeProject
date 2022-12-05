using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [Header("Player Settings")]

    public float movVelocity;
    public float limitMaxY;                // variaveis limitadoras de posição vertical.
    public float limitMinY;
    public float limitMaxX;                // variaveis limitadoras de posição horizontal.
    public float limitMinX;

    [Header("Bridge Settings")]

    public float objectVelocity;
    public float distanceToDestroy;
    public float bridgeSize;
    public GameObject PontePrefab;

    [Header("Barrel Settings")]

    public float posYTop;
    public float posYCenter;
    public float posYDown;

    public int barrelOrderTop;
    public int barrelOrderCenter;
    public int barrelOrderDow;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
