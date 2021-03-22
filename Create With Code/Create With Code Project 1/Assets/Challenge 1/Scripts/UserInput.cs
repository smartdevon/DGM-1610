using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class UserInput : MonoBehaviour
{
    public float speed = 3f, gravity = -8f, jumpForce = 10f;

    private float yDirection;
    private CharacterController controller;
    private Vector3 movement, rotation;
   
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.Set(speed * UserInput.GetAxis("Vertical"), yDirection, 0);

        yDirection += gravity * Time.deltaTime;

        if(controller.isGrounded && movement.y < 0)
        {
            yDirection = -1f;
        }

        if (UserInput.GetButtonDown("Jump"))
        {
            yDirection = jumpForce;
        }

        rotation.y = UserInput.GetAxis("Horizontal");
        transform.Rotate(rotation);
        movement = transform.TransformDirection(movement);
        controller.Move(movement * Time.deltaTime);
    }
}
