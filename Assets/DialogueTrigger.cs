using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    // For messages
    public Message[] messages;
    public Actor[] actors;

    // For distance triggers
    public Transform player;
    public GameObject dialogBox;

    public void StartDialogue()
    {
        FindObjectOfType<DialogueManager>().OpenDialogue(messages, actors);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

/*    void FixedUpdate()
    {
        if (player)
        {
            float dist = Vector3.Distance(player.position, transform.position);
            if (dist < 2)
            {
                FindObjectOfType<DialogueManager>().OpenDialogue(messages, actors);
                dialogBox.GetComponent<DialogueManager>().OpenDialogue(messages, actors);
            }
            //Debug.Log("Distance to other: " + dist);
        }

    }*/
}

[System.Serializable]

public class Message
{
    public int actorId;
    public string message;

}

[System.Serializable]
public class Actor
{
    public string name;
    public Sprite sprite;
}