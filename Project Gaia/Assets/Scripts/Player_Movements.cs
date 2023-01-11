using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movements : MonoBehaviour
{
    public float movementSpeed = 1f;   //Movement Speed of the Player
    Vector2 movement;                  //Movement Axis
    public Rigidbody2D rigidbody;      //Player Rigidbody Component
    public Animator animator;


    void FixedUpdate() 
    {
        //Time.fixedDeltaTime = interval in seconds at which physics and other fixed frame rate updates.

        rigidbody.MovePosition(rigidbody.position + movement * movementSpeed * Time.fixedDeltaTime);
    }

    // Update is called once per frame
    // gets direction, no matter if you use wasd or arrows
void Update()
{
    movement.x = Input.GetAxisRaw("Horizontal");
    movement.y = Input.GetAxisRaw("Vertical");

    // keeps track for the animation so when you move it changes where micheal is looking
    animator.SetFloat("Horizontal", movement.x);
    animator.SetFloat("Vertical", movement.y);
    animator.SetFloat("Speed", movement.sqrMagnitude);

}

}
