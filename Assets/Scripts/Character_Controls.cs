using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Character_Controls : MonoBehaviour
{
    public Rigidbody2D rb;
    public float move = 0f;
    public float move2 = 0f;
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Vertical");
        move2 = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(move2 * speed, move * speed);
    }
}
