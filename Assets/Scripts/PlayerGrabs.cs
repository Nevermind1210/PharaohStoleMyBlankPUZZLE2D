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

    public void Grab(Character_Controls character)
    {
        transform.parent = character.transform;
        character.moveSpeed = 1.5f;
    }

    public void Drop(Character_Controls character)
    {
        character.moveSpeed = 5f;
        transform.parent = null;
    }
}
