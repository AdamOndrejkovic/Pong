using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketPlayer2AI : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementSpeed;

    public GameObject ball;

    private void FixedUpdate()
    {
        if (Mathf.Abs(this.transform.position.y - ball.transform.position.y) > 50)
        {
            if (transform.position.y < ball.transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * movementSpeed;
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * movementSpeed;
            }
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0) * movementSpeed;
        }
    }
}
