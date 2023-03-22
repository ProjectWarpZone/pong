using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Paddle : Paddle
{
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.U) || Input.GetKey(KeyCode.LeftBracket))
        {
            direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.J) || Input.GetKey(KeyCode.Semicolon))
        {
            direction = Vector2.down;
        }
        else
        {
            direction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        if (direction.sqrMagnitude != 0)
        {
            _rigidbody.AddForce(direction * this.speed);
        }
    }
}
