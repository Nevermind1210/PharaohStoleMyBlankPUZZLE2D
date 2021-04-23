using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Character_Controls : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 5f;
    Vector2 movement;
    private IGrabbable objectToGrab;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if(Input.GetKeyDown(KeyCode.E))
        {
            AttemptGrab(); // invoke function if there is something to grab.
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    private void AttemptGrab()
    {
        if(objectToGrab != null)
        {
            objectToGrab.Grab();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IGrabbable grabbableObject = collision.GetComponent<IGrabbable>();
        if(grabbableObject != null)
        {
            objectToGrab = grabbableObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.GetComponent<IGrabbable>() != null)
        {
            objectToGrab = null;
        }
    }
}


