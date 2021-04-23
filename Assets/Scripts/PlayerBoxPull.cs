using System.Collections;
using UnityEngine;

public class PlayerBoxPull : MonoBehaviour
{
    public float defaultMass;
    public float imovableMass;
    public bool beingPushed;
    float xPos;
    float yPos;

    public Vector3 lastPos;

    public int mode;
    public int colliding;

    // Start is called before the first frame update
    void Start()
    {
        xPos = transform.position.x;
        yPos = transform.position.y;
        lastPos = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (mode == 0)
        {
            if (beingPushed == false)
            {
                transform.position = new Vector2(xPos, transform.position.y);
                transform.position = new Vector2(yPos, transform.position.x);
            }
            else
            {
                xPos = transform.position.x;
                yPos = transform.position.y;
            }
        }
        else if (mode == 1)
        {

            if (beingPushed == false)
            {
                GetComponent<Rigidbody2D>().mass = imovableMass;
            }
            else
            {
                GetComponent<Rigidbody2D>().mass = defaultMass;
            }

        }
    }
}
