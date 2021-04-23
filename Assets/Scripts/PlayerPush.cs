using System.Collections;
using UnityEngine;

public class PlayerGrabs : MonoBehaviour, IGrabbable
{
    Character_Controls player;

    public float distance = 1f;
    public LayerMask boxMask;
    public Collider2D objectCollider;
    public Collider2D anotherCollider;
    public bool isGrabbing = false;
    public bool yAxisOnly;
    public bool xAxisOnly;

    GameObject box;

    // OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if(Input.GetKey(KeyCode.E))
    //    {
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, (Vector2)transform.position + Vector2.right * transform.localScale.x * distance);
    }

    public void Grab()
    {
        if (objectCollider.IsTouching(anotherCollider) && isGrabbing)
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
            {
                yAxisOnly = true;
                xAxisOnly = false;
                anotherCollider.transform.parent = player.transform;
                player.moveSpeed = 1.5f;
            }    
        }

        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            yAxisOnly = true;
            xAxisOnly = false;
            anotherCollider.transform.parent = player.transform;
            player.moveSpeed = 1.5f;
        }
        else
        {
            yAxisOnly = true;
            xAxisOnly = true;
            anotherCollider.transform.parent = null;
            player.moveSpeed = 5f;
        }
    }
}
