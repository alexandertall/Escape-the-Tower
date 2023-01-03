using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlatform : MonoBehaviour
{
    [SerializeField] public float shrinkAmount = 0.5f;
    [SerializeField] public Rigidbody objectRigidbody;

    public OpenDoor door;

    public Material newMaterial;


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Puzzle_Object" && objectRigidbody.useGravity == true)
        {
            transform.localScale = new Vector3(1, shrinkAmount, 1);

            door.ToggleDoor();
            Debug.Log("The value of Opendoor is: " + door.isOpen);

            Renderer rend = GetComponent<Renderer>();
            rend.material = new Material(Shader.Find("Specular"));

        }
    }
}
