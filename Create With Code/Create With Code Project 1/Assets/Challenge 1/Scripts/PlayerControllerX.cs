using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public float gravity = -8f, jumpForce = 10f;
    public float movement;

    private float yDirection;
    private CharacterController controller;
    private Vector3 rotation;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * verticalInput * rotationSpeed * Time.deltaTime);
    }

    void Update()
    {
        movement.Set(speed * verticalInput.GetAxis("Vertical"), yDirection, 0);

        yDirection += gravity * Time.deltaTime;

        if (controller.isGrounded && movement.y < 0)
        {
            ydirection = -1f;
        }

        if(Input.GetButtonDown("Jump"))
        {
            yDirection = jumpForce;
        }
        rotationSpeed.y = verticalInput.GetAxis("Horizontal");
        transform.Rotate(rotation);
        movement = transform.TransformDirection(movement);
        controler.Move(movement * Time.deltaTime);

    }
}
