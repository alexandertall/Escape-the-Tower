using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] public bool isOpen = false;
    private bool cooldown = false;

    public void ToggleDoor()
    {
        if (!cooldown)
        {
            StartCoroutine(CoolDown());
            isOpen = !isOpen;
            if (isOpen)
            {
                // Move the door to the open position
                transform.Rotate(Vector3.up, 90f);
            }
            else
            {
                // Move the door to the closed position
                transform.Rotate(Vector3.up, -90f);
            }
        }
    }

    IEnumerator CoolDown()
    {
        cooldown = true;
        yield return new WaitForSeconds(1);
        cooldown = false;
    }
}


