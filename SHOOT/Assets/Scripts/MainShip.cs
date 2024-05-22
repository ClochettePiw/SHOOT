using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainShip : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        CheckInput();
    }

    public void CheckInput()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(-speed * Time.deltaTime, transform.position.y);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(speed * Time.deltaTime, transform.position.y);
        }
    }

    public void Moving(float move)
    {
        Debug.Log(move);
        rb.velocity = new Vector3(move * Time.deltaTime, transform.position.y);
    }
}
