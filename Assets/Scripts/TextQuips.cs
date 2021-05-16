using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextQuips : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public GameObject continueButton;

    void Start()
    {
        StartCoroutine(Type()); 
    }

    void Update()
    {
        if(textDisplay.text == sentences[index]) // if text at its end
        {
            if(continueButton != null) // if the button exist in scene
            {
                continueButton.SetActive(true); // set this true and allow the player to continue.
            }
            StartCoroutine(DestroyDelay());
        }
        
    }

    IEnumerator Type()
    {
        foreach (char letters in sentences[index].ToCharArray()) // a foreach of every letter turned into an Array
        {
            textDisplay.text += letters;
            yield return new WaitForSeconds(typingSpeed); //this is always 0 but however its related to the letters that appear on the screen
        }
    }

    IEnumerator DestroyDelay()
    {
        yield return new WaitForSecondsRealtime(2);
        {
            Destroy(textDisplay);
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false); // if we already haven't false it

        if (index < sentences.Length - 1) // continue it
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = ""; // move on.
        }
    }
}
