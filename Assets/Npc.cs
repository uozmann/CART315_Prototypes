using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    public DialogueTrigger trigger;

    // For distance
    public Transform player;
    bool touchedNpc = false;

    void FixedUpdate()
    {
        if (player)
        {
            float dist = Vector3.Distance(player.position, transform.position);
            if (dist < 2 && touchedNpc == false)
            {
                trigger.StartDialogue();
                touchedNpc = true;
            } else if (dist > 2 && touchedNpc == true)
            {
                touchedNpc = false;
            }

        }

    }
}
