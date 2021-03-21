using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// podłączyć do gracza CharacterController [component]
// podłączyć pod gracza (kamera + postać)
// podłączyć groundCheck(objekt)
public class PlayerMovementScript : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;                                     
    public float gravity = -9.81f;                               // grawiacja
    public float jumpHeight = 3f;                                // jump
    public Transform groundCheck;                                // falling
    public float groundDistance = 0.4f;                          // falling
    Vector3 velocity;                                            // grawitacja
    public LayerMask groundMask;                                 // falling 

    bool isGrounded;                                             // falling
    public GameObject Manager;

   
    void Update()
    {
        // smoother falling ↓↓↓
        
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }



        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z; // move


        controller.Move(move * speed * Time.deltaTime);             // <--WSAD ↑↑↑

        if (Input.GetButtonDown("Jump") && isGrounded)              // jump ↓↓↓
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }                                                           

        velocity.y += gravity * Time.deltaTime;                     //gravity ↓↓↓

        controller.Move(velocity * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W))
        {
            Manager.SetActive(true);
            FindObjectOfType<AudioManager>().Play("steps");
            
        }
        if(Input.GetKeyUp(KeyCode.W))
        {
            Manager.SetActive(false);
        }
        
       
        
    }
    
}
