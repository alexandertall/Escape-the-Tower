using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlatform : MonoBehaviour
{


    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Puzzle_Object")
        {
            Debug.Log("Works");
        }
    }
}
