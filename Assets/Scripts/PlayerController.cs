using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public CharacterController controller;
    public Vector3 velocity;
    public float playerSpeed;
    float horizontalInput;
    float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerInput();
    }

    // Method for allowing players to move with WASD and arrow keys
    public void PlayerInput()
    {
        
        horizontalInput = Input.GetAxis("Horizontal"); // Input detection in horizontalInput and verticalInput
        verticalInput = Input.GetAxis("Vertical");
        velocity = new Vector3 (horizontalInput, 0, verticalInput); // Directional innput Mapping with Vector 3
        controller.Move(velocity * Time.deltaTime * playerSpeed); // Controller method to control player
    }
}
