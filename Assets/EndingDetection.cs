using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndingDetection : MonoBehaviour
{
    public TextMeshProUGUI endingText;
    bool suspectFound = false;

    public void SabrinaClicked()
    {
        suspectFound = true;
        DisplayEndingText();
    }

    public void LucClicked()
    {
        suspectFound = false;
        DisplayEndingText();
    }
    void DisplayEndingText()
    {
        if (suspectFound == true)
        {
            endingText.text = "Congradulation, you have discovered the criminal!";
        } else
        {
            endingText.text = "Unfortunately, you have mistaken the criminal!";
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
