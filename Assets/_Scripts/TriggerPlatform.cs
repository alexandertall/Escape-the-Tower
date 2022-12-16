using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlatform : MonoBehaviour
{

    [SerializeField] public Rigidbody objectRigidbody;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Puzzle_Object" && objectRigidbody.useGravity == true)
        {
            Debug.Log("Works");
        }
    }
}
