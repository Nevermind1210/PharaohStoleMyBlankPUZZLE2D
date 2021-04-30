using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealAnswer : MonoBehaviour
{
    [SerializeField]
    private GameObject answer;
    [SerializeField]
    private GameObject answer2;
    [SerializeField]
    private bool revl;
    [SerializeField]
    private bool ans;
    
    // Start is called before the first frame update
    void Start()
    {
        answer.SetActive(false);

        answer2.SetActive(false);
    }

    private IEnumerator Delay(GameObject disableThis, float _Delay)
    {
        yield return new WaitForSeconds(_Delay);

        disableThis.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Memory":
                {
                    revl = true;
                    if (revl == true)
                    {
                        answer.SetActive(true);

                        StartCoroutine(Delay(answer, 0.5f));

                        revl = false;
                    }
                }
                break;
            case "Memry":
                {
                    ans = true;
                    if (ans == true)
                    {
                        answer2.SetActive(true);

                        StartCoroutine(Delay(answer2, 0.5f));

                        ans = false;
                    }
                }
                break;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }
}
