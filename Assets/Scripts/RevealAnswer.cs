using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealAnswer : MonoBehaviour
{
    [SerializeField]
    private GameObject answer;
    private bool pas;
    // Start is called before the first frame update
    void Start()
    {
        answer.SetActive(false);
    }

    private IEnumerator Delay(float _Delay)
    {
        yield return new WaitForSeconds(_Delay);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Memory":
                {
                    pas = true;
                    if (pas == true)
                    {
                        answer.SetActive(true);

                        StartCoroutine(Delay(3));

                        answer.SetActive(false);
                    }
                }
            break;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }
}
