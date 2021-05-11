using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

public class ProtagSelection : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private TextMeshProUGUI genderRole;
    [SerializeField] public Animation animation;

    [Header("Sounds")]
    [SerializeField] private AudioClip arrowClickSFX;
    [SerializeField] private AudioClip characterSelectBG;

    private void Update()
    {
        
    }

    void CharacterSelection()
    {

    }
    
}
