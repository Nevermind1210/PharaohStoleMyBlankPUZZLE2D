using System.Collections;
using UnityEngine;

public class PlayerGrabs : MonoBehaviour, IGrabbable
{
    public float distance = 1f;
    public LayerMask boxMask;
    public bool isGrabbing = false;
    public bool yAxisOnly;
    public bool xAxisOnly;

    GameObject box;

    public void Grab(Character_Controls character) // this derives from the IGrabbale script
    {
        transform.parent = character.transform; // will connect the transform of the object to the player transform and unite it
        character.moveSpeed = 1.5f; // and slow them down to a crawl
    }

    public void Drop(Character_Controls character)
    {
        character.moveSpeed = 5f; // once let go'd it will return to normal speed
        transform.parent = null; // and will null the object back into its original static space.
    }
}
