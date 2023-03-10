using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerAbility : MonoBehaviour
{
    public int stepperCollected{ get; private set; }
    public int keyCollected { get; private set; }
    public TextMeshProUGUI numberStepper;
    public GameObject stepperPrefab;
    private GameObject finalDestination;

    void Start()
    {
        gameObject.GetComponent<FlyBehaviour>().enabled = false;
        finalDestination = GameObject.Find("SNature_LiliBlossom (1)");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && stepperCollected > 0)
        {
            Instantiate(stepperPrefab, transform.position + (transform.forward * 2), transform.rotation);
            stepperCollected--;
            numberStepper.text = stepperCollected.ToString();
        } else if (Input.GetKeyDown(KeyCode.F) && stepperCollected <= 0 && keyCollected > 0)
        {
            gameObject.GetComponent<FlyBehaviour>().enabled = true;
        }
    }

    public void stepperCounter()
    {
        stepperCollected++;
    }

    public void stepperDecounter()
    {
        stepperCollected--;
    }

    public void keyCounter()
    {
        keyCollected++;
        if (keyCollected >= 2 )
        {
            gameObject.transform.position = finalDestination.transform.position + finalDestination.transform.up * 2; 
        }
    }
    public void keyDecounter()
    {
        keyCollected--;
    }
    public void updateUI()
    {
        numberStepper.text = stepperCollected.ToString();
    }
}
