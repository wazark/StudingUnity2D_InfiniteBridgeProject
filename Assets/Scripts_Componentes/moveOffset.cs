using Mono.Cecil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveOffset : MonoBehaviour
{
    //private MeshRenderer mRender; poderia ser utilizado o mesh render, mas o Render ja engloba todos os render.
    private Renderer mRender;
    private Material currentMaterial;
    private float Offset;

    public float velocity;
    public float incrementOffset;
    public string sortingLayer;
    public int orderInLayer;
    

    void Start()
    {
        mRender = GetComponent<MeshRenderer>();

        currentMaterial = mRender.material;   //acessei o componente.
        mRender.sortingLayerName = sortingLayer;  // defini a layer.
        mRender.sortingOrder = orderInLayer; // defini a ordem.


        
    }

   
    void FixedUpdate()
    {
        Offset += incrementOffset;

        currentMaterial.SetTextureOffset("_MainTex", new Vector2(Offset * velocity,0));  // o MainTex é o nome base para textura principal. 


    }
}
