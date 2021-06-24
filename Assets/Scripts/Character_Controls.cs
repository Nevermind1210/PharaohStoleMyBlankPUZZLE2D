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

        if(Input.GetKeyUp(KeyCode.E))
        {
            AttemptDrop(); // invoke function when player let go of specific key.
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
            objectToGrab.Grab(this);
        }
    }

    private void AttemptDrop()
    {
        objectToGrab.Drop(this);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        IGrabbable grabbableObject = collision.gameObject.GetComponent<IGrabbable>(); // essentially will find any object that the player is collided with and will make it to a grabbable if we allow it to
        if (grabbableObject != null)
        {
            objectToGrab = grabbableObject; // Then hey presto its a grabby thingy and you can move with it.
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<IGrabbable>() != null && !Input.GetKey(KeyCode.E)) // checks if the componenet is with that script and if the key is not being pressed
        {
            objectToGrab = null; // null it.
        }
    }
}