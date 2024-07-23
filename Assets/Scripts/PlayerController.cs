using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform cam;
    public Rigidbody rb;
    public CharacterController controller;
    public Vector3 velocity;
    public float playerSpeed;
    

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
       float horizontalInput = Input.GetAxis("Horizontal");
       float verticalInput = Input.GetAxis("Vertical");
       velocity = new Vector3(horizontalInput, 0, verticalInput).normalized; // Directional input Mapping with Vector 3
       PlayerInput();
       
    }

    // Method for allowing players to move with WASD and arrow keys
    public void PlayerInput()
    {
        float targetDirection = Mathf.Atan2(velocity.x, velocity.z) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, targetDirection, 0); 

         
     
        Vector3 newDirection = Quaternion.Euler(0, targetDirection, 0) * Vector3.forward;  
        controller.Move(velocity * Time.deltaTime * playerSpeed); // Controller method to control player
        if (velocity != Vector3.zero)
        {
            rb.MoveRotation(Quaternion.LookRotation(velocity));
        }
    }
}
