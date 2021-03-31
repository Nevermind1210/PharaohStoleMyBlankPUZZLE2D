using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [RequireComponent(typeof(Rigidbody2D))]
public class TileGame : MonoBehaviour
{
    [SerializeField]
    private float Solve = 0f;
    [SerializeField]
    private GameObject Tiles2;
    [SerializeField]
    private bool touch;

    // Start is called before the first frame update
    void Start()
    {
        Tiles2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Solve <= 0)
        {
            Tiles2.SetActive(false);
        }
        if(Solve == 1)
        {
            Tiles2.SetActive(true);
        }
        if(Solve == 2)
        {
            
        }
        if(Solve == 3)
        {
            Solve = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch(collision.gameObject.tag)
        {
            case "First":
                {
                    touch = true;
                    if (touch == true)
                    {
                        if (Solve <= 0)
                        {
                            Solve += 1;
                        }
                    }
                }
                break;
            case "Second":
                {
                    touch = true;
                    if (touch == true)
                    {
                        if (Solve <= 1)
                        {
                            Solve += 1;
                        }
                    }
                }
                break;
            case "False":
                {
                    touch = true;
                    if (touch == true)
                    {
                        if (Solve == 1)
                        {
                            Solve += 2;
                        }
                    }
                }
                break;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        touch = false;
    }
}
