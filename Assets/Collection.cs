using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    GameObject player;
    GameObject floor;
    public bool stepper;
    public bool key;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("shadow");
        floor = GameObject.Find("Separationborder");
    }

    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "shadow")
        {
            if (stepper == true)
            {
                player.GetComponent<PlayerAbility>().stepperCounter();
            } else if (key == true)
            {
                player.GetComponent<PlayerAbility>().keyCounter();
                floor.GetComponent<MeshCollider>().enabled = false;
            }
            gameObject.SetActive(false);
            player.GetComponent<PlayerAbility>().updateUI();
        }
    }
}
