using System.Collections;
using UnityEngine;

public class PlayerGrabs : MonoBehaviour, IGrabbable
{
    //Character_Controls player;

    public float distance = 1f;
    public LayerMask boxMask;
    //public Collider2D objectCollider;
    //public Collider2D anotherCollider;
    public bool isGrabbing = false;
    public bool yAxisOnly;
    public bool xAxisOnly;

    GameObject box;

    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, (Vector2)transform.position + Vector2.right * transform.localScale.x * distance);
    }

    public void Grab(Character_Controls character)
    {
        yAxisOnly = true;
        xAxisOnly = false;
        transform.parent = character.transform;
        character.moveSpeed = 1.5f;

        /*
        if (objectCollider.IsTouching(anotherCollider) && isGrabbing)
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
            {
                yAxisOnly = true;
                xAxisOnly = false;
                anotherCollider.transform.parent = player.transform;
                player.moveSpeed = 1.5f;
                Debug.Log("W and S keys are pressed");
            }    
        }

        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            yAxisOnly = true;
            xAxisOnly = false;
            anotherCollider.transform.parent = player.transform;
            player.moveSpeed = 1.5f;
            Debug.Log("A and D keys are pressed");
        }
        else
        {
            yAxisOnly = true;
            xAxisOnly = true;
            anotherCollider.transform.parent = null;
            player.moveSpeed = 5f;
        }*/
    }

    public void Drop()
    {
        transform.parent = null;
    }
}
