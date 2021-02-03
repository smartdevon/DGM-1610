using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public Rigidbody2D ballRigidbody2D;
    public Vector2 direction;
    public Vector2 yDirection;


    // Update is called once per frame
    void Update()
    {
        direction.x = UserInput.GetAxis("Horizontal") * speed;
        ballRigidbody2D.AddForce(direction, ForceMode2D.Force);

        if (Input.GetButtonDown("Jump"))
        {
            yDirection.y = jumpForce;
            ballRigidbody2D.AddForce(yDirection, ForceMode2D.Force);
        }
    }
}
