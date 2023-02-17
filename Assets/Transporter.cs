using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transporter : MonoBehaviour
{
    public GameObject receiver;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("shadow");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "shadow")
        {
            player.transform.position = receiver.transform.position;

            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Collided with player");
        }
    }
}
