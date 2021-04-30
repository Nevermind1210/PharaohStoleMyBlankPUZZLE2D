using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solution : MonoBehaviour
{
    [SerializeField]
    private GameObject Solv1;
    [SerializeField]
    private GameObject Solv2;
    [SerializeField]
    private float ANS = 0f;
    [SerializeField]
    private bool fals;

    // Start is called before the first frame update
    void Start()
    {

        fals = false;

        Solv1.SetActive(true);

        Solv2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (fals == true)
        {
            Solv1.SetActive(true);

            Solv2.SetActive(false);

            fals = false;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Sol1":
                {
                    Solv1.SetActive(false);
                    Solv2.SetActive(true);

                    ANS = 1;
                }
            break;
            case "Sol2":
                {
                    if (ANS == 1)
                    {
                        Debug.Log("YOU WIN!");
                    }
                }
            break;
            case "FALSE":
                {
                    fals = true;
                    ANS = 0;
                }
            break;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
