using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController_2 : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))

        {
            if (openTrigger)
            {
                myDoor.Play("OvenDoorOpen", 0, 0.0f);
                gameObject.SetActive(false);
            }

            else if (closeTrigger)
            {
                myDoor.Play("OvenDoorClose", 0, 0.0f);
                gameObject.SetActive(false);

            }

        }
    }
}