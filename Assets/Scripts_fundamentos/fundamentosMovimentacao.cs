using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fundamentosMovimentacao : MonoBehaviour
{
    private Rigidbody2D PlayerRigidBody;
    public float movVelocity;

    void Start()
    {
        PlayerRigidBody = GetComponent<Rigidbody2D>();    


    }

    
    void Update()
    {

        movimentation();


    }

    void movimentation()
    {

        float horizontal = Input.GetAxisRaw("Horizontal");

        PlayerRigidBody.velocity = new Vector2(horizontal * movVelocity, 0);


        float vertical = Input.GetAxisRaw("Vertical");
        PlayerRigidBody.velocity = new Vector2(vertical * movVelocity, 0);



    }
}
