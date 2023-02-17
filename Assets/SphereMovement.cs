using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    public float rotationSpeed = 0.3f;
    public bool rotate = true;

    public float translationSpeed = 0.3f;
    public bool translate = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("key holded");
            rotate = false;
            translate = false;
        }
        else
        {
            rotate = true;
            translate = true;
        }
    }

    void FixedUpdate() //use for constant updates
    {
        if (!rotate)
        {
            this.GetComponent<Transform>().Rotate(0, rotationSpeed, 0);
        }

       /* if (!translate)
        {
            this.GetComponent<Transform>().Translate(0, translationSpeed, 0);
        }*/


    }
}
