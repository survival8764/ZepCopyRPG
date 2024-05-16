using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    TopDownCharacterController controller;

    Rigidbody2D rb;

    Vector2 movementDirection = Vector2.zero;

    public float speed = 5f;

    private void Awake() 
    {
        controller = GetComponent<TopDownCharacterController>();
        rb = GetComponent<Rigidbody2D>();
        controller.OnMoveEvent += Move;
    }

    void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void FixedUpdate() 
    {
        ApplyMovement(movementDirection);
    }

    void ApplyMovement(Vector2 direction)
    {
        direction *= speed;
        rb.velocity = direction;
    }
}
