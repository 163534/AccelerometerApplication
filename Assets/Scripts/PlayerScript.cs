using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody2D rb;
    float dirX;
    float moveSpeed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 20f;
    }

    void Update()
    {
        // detects input on the accelerometer's x axis multiplies it by movement speed //
        dirX = Input.acceleration.x * moveSpeed;
        // makes sure object can't go beyond -7.5 & 7.5 on the x axies //
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -7.5f, 7.5f), transform.position.y);
    }
    private void FixedUpdate()
    {
        // moves the object depending on how much tilt on the x axis there is //
        rb.velocity = new Vector2(dirX, 0f);
    }
}
