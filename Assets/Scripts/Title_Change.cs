using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Title_Change : MonoBehaviour
{
    [SerializeField]
    private float TitleName = 0f;
    [SerializeField]
    public Text TitleText;
    [SerializeField]
    private GameObject Dog;
    [SerializeField]
    private GameObject Cat;
    [SerializeField]
    private GameObject Goldfish;
    [SerializeField]
    private GameObject Title;

    public Button dog;
    public Button cat;
    public Button goldfish;

    // Start is called before the first frame update
    void Start()
    {
        TitleText.text = "The Pharoh Stole My ________";
        TitleName = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (TitleName == 0)
        {
            Title.SetActive(true);
            Goldfish.SetActive(true);
            Dog.SetActive(true);
            Cat.SetActive(true);
        }

        if (TitleName == 0)
        {
            TitleText.text = "The Pharoh Stole My ________";
        }

        if (TitleName == 1)
        {
            TitleText.text = "The Pharoh Stole My Dog";
        }

        if (TitleName == 2)
        {
            TitleText.text = "The Pharoh Stole My Goldfish";
        }

        if (TitleName == 3)
        {
            TitleText.text = "The Pharoh Stole My Cat";
        }

        if (TitleName != 0)
        {
            Title.SetActive(true);
            Goldfish.SetActive(false);
            Dog.SetActive(false);
            Cat.SetActive(false);
        }

    }

    public void RaiseStat(int value)
    {
        switch (value)
        {
            case 1:
                {
                    if (TitleName == 0)
                    {
                        TitleName += 1;
                    }
                }
            break;

            case 2:
                {
                    if (TitleName == 0)
                    {
                        TitleName += 2;
                    }
                }
            break;

            case 3:
                {
                    if (TitleName == 0)
                    {
                        TitleName += 3;
                    }
                }
            break;

        }
    }
}
